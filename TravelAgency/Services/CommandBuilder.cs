﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Windows;
using TravelAgency.Models;

namespace TravelAgency.Services
{
    public class CommandBuilder : IBuilder
    {
        private readonly SqlCommand _command;
        public CommandBuilder()
        {
            _command = new SqlCommand();
        }

        public CommandBuilder AddParameter(string parameter, object value)
        {
            _command.Parameters.AddWithValue(parameter, value);
            return this;
        }

        public CommandBuilder AddDateParameter(string parameter, object value)
        {
            _command.Parameters.Add(parameter, SqlDbType.DateTime).Value = value;
            return this;
        }

        public CommandBuilder SetConnection(SqlConnection connection)
        {
            _command.Connection = connection;
            return this;
        }

        public CommandBuilder SetCommandText(string command)
        {
            _command.CommandText = command;
            return this;
        }

        public IBuilder NewBuilder()
        {
            return new CommandBuilder();
        }

        public object Build()
        {
            return _command;
        }

        private void GenerateAttributesString<T>(T value, CommandType commandType) where T : Model
        {
            var valueType = value?.GetType();
            var properties = valueType?.GetProperties();
            var arrayOfNames = (properties ?? Array.Empty<PropertyInfo>()).Select(p => p.Name).ToArray();
            var arrayOfValues = (properties ?? Array.Empty<PropertyInfo>()).Select(p => p.GetValue(value)?.ToString()).ToArray();
            var listOfAttributes = new List<string>();
            string updateStringOfProperties = null;
            var stringOfProperties = "";
            stringOfProperties += string.Join( "", properties.Select(p => 
                !(p.Name == "Id" && (commandType == CommandType.Get || commandType == CommandType.Insert))
                ? properties.ToList().IndexOf(p) != 0 
                    ? ", " + p.Name
                    : p.Name
                : null ));

            string stringOfAttributes = null;
            if (properties != null)
                for (var i = 0; value is Vouchers ? i < 12 : i < properties.Length; i++)
                {
                    if(value is Vouchers && i > 13)
                        break;
                    listOfAttributes.Add($"@{i}");
                    if(arrayOfValues[i] == "0")
                        continue;
                    stringOfAttributes += i != 0 
                        ? ", " + $"@{i}"
                        : $"@{i}";
                    updateStringOfProperties += i != 0
                        ? !(commandType == CommandType.Update && i == properties.Length - 1)
                            ? ", " + arrayOfNames[i] + " = " + listOfAttributes[i]
                            : null
                        : arrayOfNames[i] + " = " + listOfAttributes[i];

                }

            var arrayOfAttributes = listOfAttributes.ToArray();

            var resultString = commandType switch
            {
                CommandType.Insert =>
                    $"INSERT INTO {value.GetType().Name} ({stringOfProperties}) output INSERTED.Id VALUES ({stringOfAttributes})",
                CommandType.Update => $"UPDATE {value.GetType().Name} " + $"SET {updateStringOfProperties}" +
                                      $" WHERE Id = {value?.Id}",
                _ => null
            };

            SetCommandText(resultString);

            if (properties != null)
                for (var i = 0;  value is Vouchers ? i < 12 : i < properties.Length; i++)
                {
                    AddParameter(arrayOfAttributes[i], DateTime.TryParse(arrayOfValues[i], out DateTime time) ? (object) time : arrayOfValues[i]);
                }
        }

        public CommandBuilder SetCommandText<T>(CommandType commandType, T value = null) where T : Model
        {
            switch (value)
            {
                case Clients client:
                    switch (commandType)
                    {
                        case CommandType.Delete:
                            SetCommandText($"DELETE FROM {typeof(T).Name} WHERE Id = {value.Id}");
                            break;
                        case CommandType.Insert:
                           GenerateAttributesString(client, CommandType.Insert);
                            break;
                        case CommandType.Update:
                            GenerateAttributesString(client, CommandType.Update);
                            break;
                        case CommandType.Get:
                            GetValue<T>();
                            break;
                    }
                    break;
                case Hotels hotel:
                    switch (commandType)
                    {
                        case CommandType.Delete:
                            SetCommandText($"DELETE FROM Hotels WHERE Id = {hotel.Id}");
                            break;
                        case CommandType.Insert:
                           GenerateAttributesString(hotel, CommandType.Insert);
                            break;
                        case CommandType.Update:
                            GenerateAttributesString(hotel, CommandType.Update);
                            break;
                        case CommandType.Get:
                            GetValue<T>();
                            break;
                    }
                    break;
                case Vouchers voucher:
                    switch (commandType)
                    {
                        case CommandType.Delete:
                            SetCommandText($"DELETE FROM Vouchers WHERE Id = {voucher.Id}");
                            break;
                        case CommandType.Insert:
                            GenerateAttributesString(voucher, CommandType.Insert);
                            break;
                        case CommandType.Update:
                            GenerateAttributesString(voucher, CommandType.Update);
                            break;
                        case CommandType.Get:
                            GetValue<T>();
                            break;
                    }
                    break;

                default:
                    GetValue<T>();
                    break;
            }

            return this;
        }

        private void GetValue<T>() where T : Model
        {
            var value = (Model)Activator.CreateInstance(typeof(T));
            _command.CommandText = value switch
            {
                Vouchers voucher =>
                    "select v.Id, v.StartDate, v.EndDate, v.Duration, v.ClientId, v.HotelId, v.StuffId," +
                    " v.AdditService1Id, v.AdditService2Id, v.AdditService3Id, v.RestTypeId, v.PaymentStatus," +
                    " v.BookingStatus, c.Name, c.Surname, c.Patronymic, h.Name, s.Name, s.Surname," +
                    " s.Patronymic, a1.Name, a2.Name, a3.Name, r.Name" + " from Vouchers as v" +
                    " inner join Clients as c on" + " v.ClientId = c.Id" + " inner join Hotels as h on" +
                    " v.HotelId = h.Id" + " inner join Stuff as s on" + " v.StuffId = s.Id" +
                    " inner join AdditionalServices as a1 on" + " v.AdditService1Id = a1.Id" +
                    " inner join AdditionalServices as a2 on" + " v.AdditService2Id = a2.Id" +
                    " inner join AdditionalServices as a3 on" + " v.AdditService3Id = a3.Id" +
                    " inner join RestTypes as r on" + " v.RestTypeId = r.Id",
                _ => $"SELECT * FROM {typeof(T).Name}"
            };
        }

        public enum CommandType
        {
            Get, Delete, Insert, Update
        }
    }
}