using System;
public class MonkeyTask{

	private static int[] Peek(String str){ // Использую эту функцию, чтобы строка - <xi_di> распределилась на два значения - xi и di(C# чай не C++)
		String[] S = str.Split(' ');
		int xi = Convert.ToInt32(S[0]);
		int di = Convert.ToInt32(S[1]);
		return new int[]{xi,di};
	}

	public static void Main(String[] args){
		int n = 0;//Хранит кол-во обезьян в зоопарке 
		while(true){
			try{
				n = Convert.ToInt32(Console.ReadLine());//Ввод данных о количестве обезьян				
				break;
			}catch{
				Console.Write("Введите количество обезьян должно быть целочисленным.");
				return;
			}
		}
		int[] MON = new int [n];
		int[] BAN = new int [n];
		for(int i=0;i<n;i++){
			while(true){
				try{
					int [] MAS = Peek(Console.ReadLine());//Получаю входные данные в приятном виде
					MON[i]=MAS[0];
					BAN[i]=MAS[0]+MAS[1];
					break;
				}catch{
					Console.WriteLine("Неверный форма ввода данных.\nИспользуйте пробел между значениями.");
					return;
				}
			}
		}
		for(int i=0;i<n;i++){
			for(int j=0;j<n;j++){
				if(MON[i]==BAN[j]&&MON[j]==BAN[i]) goto _End;//Проверка, есть ли обезьяны, которые попали друг в друга
			}	
		}
		Console.WriteLine("NO");
		return;
	   _End:Console.WriteLine("YES");
	}
}
