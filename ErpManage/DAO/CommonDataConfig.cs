using System.Configuration;

namespace Daniel.Liu.DAO
{
	/// <summary>
	/// ���ߣ���־��(Daniel Liu)
	/// ���ã��������ݿ�Ĭ�������ַ����������ࡣ
	/// ���ڣ�2005-04-24
	/// </summary>
	public class CommonDataConfig
	{
		/// <summary>
		/// ���ݿ������ַ���
		/// </summary>
		//public static string ConnectionDefaultStr = "server=grd4-daniel-liu;database=readsystem;uid=sa;pwd=liuandliu";
        public static string ConnectionDefaultStr = ConfigurationSettings.AppSettings["ConnStr"];

		/// <summary>
		/// CommonDataConfig
		/// </summary>
		public CommonDataConfig()
		{
			try
			{
				ConnectionDefaultStr = ConfigurationSettings.AppSettings["ConnStr"];
//				if (ConnectionDefaultStr != null)
//				{
//					byte[] data = Convert.FromBase64String(ConnectionDefaultStr);
//					ConnectionDefaultStr = ASCIIEncoding.ASCII.GetString(data);
//				}
//				byte[] data = System.Text.ASCIIEncoding.ASCII.GetBytes(this.textBox1.Text); 
//				string str = Convert.ToBase64String(data);
			}
			catch
			{
				ConnectionDefaultStr = null;
			}
		}
	}
}