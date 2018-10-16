using System;
using System.Data;
using System.Data.OracleClient;


namespace Daniel.Liu.DAO
{
	/// <summary>
	/// ���ߣ���־��(Daniel Liu)
	/// ���ã�Oracle�����ݿ����᷽ʽ���ࡣ
	/// ���ڣ�2005-04-24
	/// </summary>
	public class CommonOracle : CommonInterface
	{
		/// <summary>
		/// Ĭ�ϵĹ��췽��
		/// </summary>
		public CommonOracle()
		{
			connstr = CommonDataConfig.ConnectionDefaultStr;
			Initial();
		}

		/// <summary>
		/// ���в����Ĺ��췽��
		/// </summary>
		/// <param name="Connstr_Param">���ݿ������ַ���</param>
		public CommonOracle(String Connstr_Param)
		{
			connstr = Connstr_Param;
			Initial();

		}

		/// <summary>
		/// ��ʼ��
		/// </summary>
		private void Initial()
		{
			try
			{
				if (connstr == null)
				{
					throw(new Exception("�����ַ���û����web.config������"));
				}
				this.conn = new OracleConnection(connstr);
				this.cmd = new OracleCommand();
				cmd.Connection = this.conn;
               
               
				this.conn.Open();
			}
			catch (Exception e)
			{
				throw e;
			}

		}

		private OracleConnection conn = null;
		private OracleCommand cmd = null;
		private OracleTransaction trans = null;
		private String connstr = null;

		/// <summary>
		/// ��ʼһ������
		/// </summary>
		public void BeginTrans()
		{
			trans = conn.BeginTransaction();
			cmd.Transaction = trans;
		}

		/// <summary>
		/// �ύһ������
		/// </summary>
		public void CommitTrans()
		{
			trans.Commit();
		}

		/// <summary>
		/// �ع�һ������
		/// </summary>
		public void RollbackTrans()
		{
			trans.Rollback();
		}

		/// <summary>
		/// ִ��һ��SQL���
		/// </summary>
		/// <param name="sql"></param>
		public void Execute(String sql)
		{
			try
			{
				cmd.CommandType = CommandType.Text;
				cmd.CommandText = sql;
				cmd.ExecuteNonQuery();
			}
			catch (Exception e)
			{
				throw e;
			}
		}

		/// <summary>
		/// ִ��SQL��䣬��䵽ָ����DataTable�У�����DataSet
		/// </summary>
		/// <param name="QueryString">SQL���</param>
		/// <param name="strTable">DataTable������</param>
		/// <returns>DataSet���ݼ���</returns>
		public DataSet ExeForDst(String QueryString, String strTable)
		{
			DataSet ds = new DataSet();

			OracleDataAdapter ad = new OracleDataAdapter();
			cmd.CommandType = CommandType.Text;
			cmd.CommandText = QueryString;
			try
			{
				ad.SelectCommand = cmd;
				ad.Fill(ds, strTable);
			}
			catch (Exception e)
			{
				throw e;
			}
			return ds;
		}

		/// <summary>
		/// ִ��һ��SQL��䣬����DataSet�����
		/// </summary>
		/// <param name="QueryString">SQL���</param>
		/// <returns>DataSet�����</returns>
		public DataSet ExeForDst(String QueryString)
		{
			DataSet ds = new DataSet();
			OracleDataAdapter ad = new OracleDataAdapter();
			cmd.CommandType = CommandType.Text;
			cmd.CommandText = QueryString;
			try
			{
				ad.SelectCommand = cmd;
				ad.Fill(ds);
			}
			catch (Exception e)
			{
				throw e;
			}
			return ds;
		}

		/// <summary>
		/// ִ��SQL��䣬����DataTable
		/// </summary>
		/// <param name="QueryString">SQL���</param>
		/// <param name="TableName">DataTable������</param>
		/// <returns>DataTable�Ľ����</returns>
		public DataTable ExeForDtl(String QueryString, String TableName)
		{
			try
			{
				DataSet ds;
				DataTable dt;
				ds = ExeForDst(QueryString, TableName);
				dt = ds.Tables[TableName];
				ds = null;
				return dt;
			}
			catch
			{
				throw;
			}
			finally
			{
			}
		}

		/// <summary>
		/// ִ��SQL��䣬����Ĭ��DataTable
		/// </summary>
		/// <param name="QueryString">SQL���</param>
		/// <returns>DataTable�����</returns>
		public DataTable ExeForDtl(String QueryString)
		{
			try
			{
				DataSet ds;
				DataTable dt;
				ds = ExeForDst(QueryString);
				dt = ds.Tables[0];
				ds = null;
				return dt;
			}
			catch
			{
				throw;
			}
			finally
			{
			}
		}

		/// <summary>
		/// ִ��SQL��䣬����IDataReader�ӿ�
		/// </summary>
		/// <param name="QueryString">SQL���</param>
		/// <returns>IDataReader�ӿ�</returns>
		public IDataReader ExeForDtr(String QueryString)
		{
			try
			{
				cmd.CommandType = CommandType.Text;
				cmd.CommandText = QueryString;
				return cmd.ExecuteReader();
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// ����IDbCommand�ӿ�
		/// </summary>
		/// <returns>IDbCommand�ӿ�</returns>
		public IDbCommand GetCommand()
		{
			try
			{
				return this.cmd;
			}
			catch (Exception e)
			{
				throw e;
			}
		}

		/// <summary>
		/// ����IDbConnection�ӿ�
		/// </summary>
		/// <returns>IDbConnection�ӿ�</returns>
		public IDbConnection GetConn()
		{
			return this.conn;
		}

		/// <summary>
		/// ��һ����������
		/// </summary>
		public void Open()
		{
			if (conn.State.ToString().ToUpper() != "OPEN")
			{
				this.conn.Open();
			}
		}

		/// <summary>
		/// �ر�һ����������
		/// </summary>
		public void Close()
		{
			if (conn.State.ToString().ToUpper() == "OPEN")
			{
				this.conn.Close();
			}
		}

		/// <summary>
		/// ����ִ�д��в�����SQL��䣨���Ǵ洢���̣�
		/// </summary>
		/// <param name="SQLText">���в�����SQL���</param>
		/// <param name="Parameters">���ݵĲ����б�</param>
		/// <param name="ParametersValue">ͬ�����б��Ӧ�Ĳ���ֵ�б�</param>
		public void ExecuteNonQuery(string SQLText, string[] Parameters, string[] ParametersValue)
		{
			cmd.CommandType = CommandType.Text;
			this.cmd.CommandText = SQLText;
			for (int i = 0; i < Parameters.Length; i++)
			{
				this.cmd.Parameters.Add("@" + Parameters[i].ToString(), ParametersValue[i].ToString());
			}
			this.cmd.ExecuteNonQuery();
		}

        /// <summary>
        /// ����ִ�д��в�����SQL��䣨���Ǵ洢���̣�
        /// </summary>
        /// <param name="SQLText">���в�����SQL���</param>
        /// <param name="Parameters">���ݵĲ����б�</param>
        /// <param name="ParametersValue">ͬ�����б��Ӧ�Ĳ���ֵ�б�</param>
        public void ExecuteNonQueryBySqlParameters(string SQLText, System.Data.SqlClient.SqlParameter[] OracleParameters)
        {
           
        }



		/// <summary>
		/// ִ�ж�sql���
		/// </summary>
		/// <param name="strSQLs">sql�������</param>
		/// <returns></returns>
		public int ExecuteSqls(string[] strSQLs)
		{
			trans = conn.BeginTransaction();
			try
			{
				cmd.Transaction = trans;
				cmd.CommandType = CommandType.Text;
				foreach (string str in strSQLs)
				{
					cmd.CommandText = str;
					cmd.ExecuteNonQuery();
				}
				trans.Commit();
				return 0;
			}
			catch (OracleException e)
			{
				trans.Rollback();
				throw e;
			}
		}

		#region ִ��SQL��䵽DataSet,ָ��TableName,����DataSet ExeForFillDst
		/// <summary>
		/// ִ��һ��SQL��䣬����DataSet�����
		/// </summary>
		/// <param name="QueryString">SQL���</param>
		/// <param name="pDS">ָ��DataSet</param>
		/// <param name="pTableName">pTableName</param>
		/// <returns>DataSet�����</returns>
		public DataSet ExeForFillDst(String QueryString,DataSet pDS,String pTableName)
		{
			try
			{
				OracleDataAdapter ad = new OracleDataAdapter();
				cmd.CommandText=QueryString;
				ad.SelectCommand =cmd;
				ad.Fill(pDS,pTableName);
			}
			catch (Exception e)
			{ 
				throw e;
			}
			return pDS;
		}

		#endregion

		#region ִ�д洢����void ExecuteSP(string StoredProcedureName, string[] Parameters, string[] ParametersValue, string[] ParametersType)

		/// <summary>
		/// ִ�д洢����
		/// </summary>
		/// <param name="StoredProcedureName">�洢���̵�����</param>
		/// <param name="Parameters">���ݵĲ����б�</param>
		/// <param name="ParametersValue">ͬ�����б��Ӧ�Ĳ���ֵ�б�</param>
		/// <param name="ParametersType">ͬ�����б��Ӧ�Ĳ��������б�</param>
		public void ExecuteSP(string StoredProcedureName, string[] Parameters, string[] ParametersValue, string[] ParametersType)
		{
			try
			{
				this.cmd.Parameters.Clear();
				this.cmd.CommandText = StoredProcedureName;
				this.cmd.CommandType = CommandType.StoredProcedure;
				for (int i = 0; i < Parameters.Length; i++)
				{
					OracleParameter myParm = this.cmd.Parameters.Add("@" + Parameters[i], Type.GetType(ParametersType[i].ToString()));
					myParm.Value = ParametersValue[i];
				}
				this.cmd.ExecuteNonQuery();
			}
			catch (Exception e)
			{
				throw e;
			}
		}

		#endregion

		#region ִ�д洢���̷���DataTable ExecuteSPForDtl

		/// <summary>
		/// ִ�д洢���̷���DataTable
		/// </summary>
		/// <param name="StoredProcedureName">�洢������</param>
		/// <param name="ParametersNames">���������</param>
		/// <param name="ParametersValue">�������ֵ</param>
		/// <returns>DataTable</returns>
		public DataTable ExecuteSPForDtl(string StoredProcedureName, string[] ParametersNames, object[] ParametersValue)
		{
			cmd.Parameters.Clear();
			DataTable pDT = new DataTable();
			cmd.CommandText = StoredProcedureName;
			cmd.CommandType = CommandType.StoredProcedure;
			for (int i = 0; i < ParametersNames.Length; i++)
			{
				cmd.Parameters.Add(ParametersNames[i], ParametersValue[i]);
			}
			OracleDataReader SDR = cmd.ExecuteReader();
			for (int i = 0; i < SDR.FieldCount; i++)
			{
				pDT.Columns.Add(SDR.GetName(i), SDR.GetFieldType(i));
			}
			while (SDR.Read())
			{
				DataRow pDr1 = pDT.NewRow();
				for (int i = 0; i < pDT.Columns.Count; i++)
				{
					pDr1[i] = SDR.GetValue(i);

				}
				pDT.Rows.Add(pDr1);
			}
			SDR.Close();
			return pDT;
		}

		#endregion

		#region ִ�д洢���̷���bool  ExecuteSP(string StoredProcedureName, string[] ParametersNames, object[] ParametersValue)

		/// <summary>
		/// ִ�д洢���̷���bool
		/// </summary>
		/// <param name="StoredProcedureName">�洢������</param>
		/// <param name="ParametersNames">���������</param>
		/// <param name="ParametersValue">�������ֵ</param>
		/// <returns>bool</returns>
		public bool ExecuteSP(string StoredProcedureName, string[] ParametersNames, object[] ParametersValue)
		{
			try
			{
				cmd.Parameters.Clear();
				cmd.CommandText = StoredProcedureName;
				cmd.CommandType = CommandType.StoredProcedure;
				for (int i = 0; i < ParametersNames.Length; i++)
				{
					cmd.Parameters.Add(ParametersNames[i], ParametersValue[i]);
				}
				cmd.ExecuteNonQuery();
				return true;
			}
			catch (Exception e)
			{
				throw e;
			}
		}

		#endregion

        ///<summary>
        /// ִ�д洢����,�õ������DataSet
        /// </summary>
        /// <param name="sqname">�洢��������</param>
        /// <param name="array">����������ֵ������</param>
        /// <returns>����True��False</returns>
        public DataSet ExcuteSp(string sqname, string[,] array)
        {
            try
            {
                DataSet dset = new DataSet();

                
                return dset;
            }
            catch (Exception e)
            {
                throw e;
            }
        }



		/// <summary>
		/// ִ��sql��䷵�ص�һ�е�һ�е�ֵ
		/// </summary>
		/// <param name="QueryString">sql��ѯ���</param>
		/// <returns>�����κ����͵Ķ���</returns>
		public object ExecuteScalar(string QueryString)
		{
			cmd.CommandType = CommandType.Text;
			cmd.CommandText = QueryString;
			try
			{
				return cmd.ExecuteScalar();
			}
			catch (Exception e)
			{
				throw e;
			}
		}

		/// <summary>
		/// getDataAdapter
		/// </summary>
		public IDataAdapter getDataAdapter(string sql)
		{
			return new OracleDataAdapter(sql, this.conn);
		}

		/// <summary>
		/// getCommandBuilder
		/// </summary>
		public ICommandBuilder getCommandBuilder()
		{
			return new OracleCmdBuilder();
		}
	}
}