using PdfSharp.Drawing;
using PdfSharp.Pdf;

using Prism.Commands;
using Prism.Mvvm;

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Threading;

using TravelAgency.Models;
using TravelAgency.Services;
using TravelAgency.Views;

using static TravelAgency.Services.CommandBuilder;
using static TravelAgency.Services.WindowMappingService;

namespace TravelAgency.ViewModels
{
    class VouchersControl : BindableBase
    {
        private readonly DispatcherTimer _searchTimer = new DispatcherTimer();
        public VouchersControl()
        {
            Vouchers = GetVouchers().Result;

            _searchTimer.Interval = TimeSpan.FromSeconds(1);
            _searchTimer.Tick += (s, e) => Search();
        }

        private async Task<List<Vouchers>> GetVouchers()
        {
            await using var connection = new SqlConnection(App.GetConString());

            var command = BuilderFactory.NewBuilder<CommandBuilder>()
                .SetCommandText<Vouchers>(CommandBuilder.CommandType.Get)
                .SetConnection(connection)
                .Build()
                .To<SqlCommand>();

            await connection.OpenAsync();

            var adapter = new SqlDataAdapter(command);
            var dataSet = new DataSet();
            adapter.Fill(dataSet);

            AllVouchers = dataSet.Tables[0].AsEnumerable().Select(datarow => new Vouchers
            {
                Id = datarow.Field<int>(0),
                StartDate = datarow.Field<DateTime>(1),
                EndDate = datarow.Field<DateTime>(2),
                Duration = datarow.Field<int>(3),
                ClientId = datarow.Field<int>(4),
                HotelId = datarow.Field<int>(5),
                StuffId = datarow.Field<int>(6),
                AdditService1Id = datarow.Field<int>(7),
                AdditService2Id = datarow.Field<int>(8),
                AdditService3Id = datarow.Field<int>(9),
                RestTypeId = datarow.Field<int>(10),
                PaymentStatus = datarow.Field<string>(11),
                BookingStatus = datarow.Field<string>(12),
                ClientName = datarow.Field<string>(13),
                ClientSurname = datarow.Field<string>(14),
                ClientPatronymic = datarow.Field<string>(15),
                HotelName = datarow.Field<string>(16),
                StuffName = datarow.Field<string>(17),
                StuffSurname = datarow.Field<string>(18),
                StuffPatronymic = datarow.Field<string>(19),
                AdditServiceName1 = datarow.Field<string>(20),
                AdditServiceName2 = datarow.Field<string>(21),
                AdditServiceName3 = datarow.Field<string>(22),
                RestTypeName = datarow.Field<string>(23)
            }).ToList();

            return AllVouchers;
        }

        private string _nameSearch;
        public string NameSearch
        {
            get => _nameSearch;
            set
            {
                SetProperty(ref _nameSearch, value);
                _searchTimer.Stop();
                _searchTimer.Start();
            }
        }

        private void Search()
        {
            Vouchers = AllVouchers.Where(p => Services.Math.LevenshteinDistance(p.ClientName, NameSearch) < 6 ||
            Services.Math.LevenshteinDistance(p.ClientSurname, NameSearch) < 6 ||
            Services.Math.LevenshteinDistance(p.ClientPatronymic, NameSearch) < 6 ||
            Services.Math.LevenshteinDistance(p.StuffName, NameSearch) < 6 ||
            Services.Math.LevenshteinDistance(p.StuffSurname, NameSearch) < 6 ||
            Services.Math.LevenshteinDistance(p.StuffPatronymic, NameSearch) < 6).ToList();

            if (Vouchers.Count == 0)
                Vouchers = AllVouchers;
            _searchTimer.Stop();
        }

        private async void AddVoucher()
        {
            var result = await OpenVouchersDetailsView(HandleType.Add);

            await using var connection = new SqlConnection(App.GetConString());
            var command = BuilderFactory.NewBuilder<CommandBuilder>()
                .SetCommandText(CommandBuilder.CommandType.Insert, result)
                .Build()
                .To<SqlCommand>();

            await connection.OpenAsync();
            var Id = await command.ExecuteScalarAsync();

            Vouchers = await GetVouchers();
            App.ShowNotification("Добавление путевки", $"Путевка №{Id} добавлена успешно.");
        }

        private void Sort(bool fromButton)
        {
            if (_isAsc)
                _isAsc = !_isAsc;
            Vouchers = _isAsc
                ? Vouchers.AsEnumerable().OrderBy(p => p.ClientSurname).ToList()
                : Vouchers.AsEnumerable().OrderByDescending(p => p.ClientSurname).ToList();

        }

        private async void GetVoucherDetails()
        {
            if (CurrentVoucher == null)
                return;

            var result = await OpenVouchersDetailsView(HandleType.View);

            await using var connection = new SqlConnection(App.GetConString());
            var command = BuilderFactory.NewBuilder<CommandBuilder>()
                .SetCommandText(CommandBuilder.CommandType.Update, result)
                .SetConnection(connection)
                .Build()
                .To<SqlCommand>();

            await connection.OpenAsync();
            await command.ExecuteNonQueryAsync();

            Vouchers = await GetVouchers();

        }

        private async Task<Vouchers> OpenVouchersDetailsView(HandleType handleType)
        {
            var vm = new VouchersDetailsViewModel(CurrentVoucher, handleType)
            {
                Title = handleType != HandleType.Add
                ? $"Путевка №{CurrentVoucher.Id}"
                : "Добавление клиента"
            };

            ShowModalWindow<VoucherDetails>(vm);

            while (true)
            {

                await Task.Delay(TimeSpan.FromSeconds(2));
                if (vm.Answer)
                    break;
            }

            return vm.Voucher;
        }

        private async void DeleteVoucher()
        {
            if (CurrentVoucher == null)
                return;

            var voucher = CurrentVoucher;

            await using var connection = new SqlConnection(App.GetConString());

            var command = BuilderFactory.NewBuilder<CommandBuilder>()
                .SetCommandText(CommandBuilder.CommandType.Delete, CurrentVoucher)
                .SetConnection(connection)
                .Build()
                .To<SqlCommand>();

            await connection.OpenAsync();
            await command.ExecuteNonQueryAsync();

            Vouchers = await GetVouchers();
            App.ShowNotification("Удаление путевки", $"Путевка №{voucher.Id} успешно удалена.");
        }


        private List<Vouchers> _vouchers;

        public List<Vouchers> Vouchers { get => _vouchers; set => SetProperty(ref _vouchers, value); }

        private Vouchers _currentVoucher;
        public Vouchers CurrentVoucher { get => _currentVoucher; set => SetProperty(ref _currentVoucher, value); }

        private List<Vouchers> _allVouchers;

        public List<Vouchers> AllVouchers { get => _allVouchers; set => SetProperty(ref _allVouchers, value); }

        private DelegateCommand _sortCommand;
        public DelegateCommand SortCommand => _sortCommand ??= new DelegateCommand(() => this.Sort(true));

        private DelegateCommand _getVoucherCommand;
        public DelegateCommand GetVoucherCommand => _getVoucherCommand ??= new DelegateCommand(this.GetVoucherDetails);

        private DelegateCommand _deleteVoucherCommand;
        public DelegateCommand DeleteVoucherCommand => _deleteVoucherCommand ??= new DelegateCommand(this.DeleteVoucher);

        private DelegateCommand _addVoucherCommand;
        public DelegateCommand AddVoucherCommand => _addVoucherCommand ??= new DelegateCommand(this.AddVoucher);

        private DelegateCommand _printVoucherCommand;
        public DelegateCommand PrintVoucherCommand => _printVoucherCommand ??= new DelegateCommand(this.PrintVoucher);

        private void PrintVoucher()
        {
            if (CurrentVoucher == null)
                return;

            var mainFont = new XFont("Times New Roman", 22, XFontStyle.Bold);
            var font = new XFont("Times New Roman", 18, XFontStyle.Regular);

            var filename = $"Voucher{CurrentVoucher.Id}.pdf";

            const int x = 150;

            try
            {
                BuilderFactory.NewBuilder<PdfBuilder>()
                       .SetTitle($"Путевка №{CurrentVoucher.Id}")

                       .DrawString($"Путевка №{CurrentVoucher.Id}", mainFont, 0, 15)
                       .DrawString($"Клиент:{CurrentVoucher.ClientSurname} {CurrentVoucher.ClientName} {CurrentVoucher.ClientPatronymic}",
                           font, x, 45 , XStringFormats.CenterLeft)
                       .DrawString($"Сотрудник:{CurrentVoucher.StuffSurname} {CurrentVoucher.StuffName} {CurrentVoucher.StuffPatronymic}",
                           font, x, 75, XStringFormats.CenterLeft)
                       .DrawString($"Отель: {CurrentVoucher.HotelName}", font, x, 105, XStringFormats.CenterLeft)
                       .DrawString($"Вид отдыха: {CurrentVoucher.RestTypeName}", font, x, 135, XStringFormats.CenterLeft)

                       .DrawString($"Доп услуга 1: {CurrentVoucher.AdditServiceName1}", font, x, 165, XStringFormats.CenterLeft)
                       .DrawString($"Доп услуга 2: {CurrentVoucher.AdditServiceName2}", font, x, 195, XStringFormats.CenterLeft)
                       .DrawString($"Доп услуга 3: {CurrentVoucher.AdditServiceName3}", font, x, 225, XStringFormats.CenterLeft)

                       .DrawString($"Статус оплаты: {CurrentVoucher.PaymentStatus}", font, x, 255, XStringFormats.CenterLeft)
                       .DrawString($"Статус бронирования: {CurrentVoucher.BookingStatus}", font, x, 285, XStringFormats.CenterLeft)

                       .DrawString($"Дата вылета: {CurrentVoucher.StartDate.ToShortDateString()}", font, x, 315, XStringFormats.CenterLeft)
                       .DrawString($"Дата прилета: {CurrentVoucher.EndDate.ToShortDateString()}", font, x, 345, XStringFormats.CenterLeft)
                       .Build()
                       .To<PdfDocument>()
                       .Save(filename);

                var process = new Process();
                process.StartInfo = new ProcessStartInfo(filename)
                {
                    UseShellExecute = true
                };
                process.Start();
            }
            catch (Exception e)
            {
                App.ShowNotification("Ошибка pdf формат", e.Message);
            }
        }

        private bool _isAsc = true;
    }
}
