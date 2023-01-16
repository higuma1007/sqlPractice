using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sqlPractice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void sqltest_Clicked(object sender, EventArgs e)
        {
            // 先ほどコピーした接続文字列を貼り付ける
            var connectionString = @"Data Source=(localdb)\ProjectModels;Initial Catalog=testdb;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

            // 実行するSELECT文
            var sql = "SELECT * FROM test";

            // 接続のためのオブジェクトを生成
            // 実行後にオブジェクトのCloseが必要なため基本的にusing文で囲う
            using (var connection = new SqlConnection(connectionString))
            {
                // 接続開始
                connection.Open();

                // SqlCommand：DBにSQL文を送信するためのオブジェクトを生成
                // SqlDataReader：読み取ったデータを格納するためのオブジェクトを生成
                using (var command = new SqlCommand(sql, connection))
                using (var reader = command.ExecuteReader())
                {
                    // 1行ごとに読み取る。読み取ったらtrue
                    while (reader.Read())
                    {
                        // 列名を指定して、読み取ったデータをコンソール上に表示
                        MessageBox.Show($""+
//                        Console.WriteLine($"" +
                            $"{reader["Name"]}\t\t" +
                            $"{reader["Age"]}\t\t" +
                            $"{reader["Birthday"]}");
                    }
                }
            }
        }
    }
}
