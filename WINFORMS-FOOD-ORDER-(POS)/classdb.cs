using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.Sqlite;

namespace WINFORMS_FOOD_ORDER__POS_
{
    internal class classdb
    {
        private static readonly string ConnectString = @"Data Source = WINDOWSFORMS-FOOD-ORDER-(POS).db";

        public static void Initialize()
        {
            using (var conn = new SqliteConnection(ConnectString))
            {
                conn.Open();
                ADMINACC(conn);
                PRODUCTS(conn);
                CASHIERACC(conn);
                CASHIERSELLS(conn);
                CASHIEREPORT(conn);
                ADDSON(conn);
                TESTDATA(conn);
            }
        }
        private static void TESTDATA(SqliteConnection conn)
        {
            // Veteran Tip: We use a multi-insert statement to keep it clean and fast.
            // I have ensured every name is unique and the dates cover a full 5-year range.
            string query = @"
    -- 2022 Data
    INSERT INTO CASHIEREPORT (CASHIERNAME, TOTALSELLS, EVALUATION, CREATEDATE) VALUES ('Liam_22', '15200', 'Excellent', '2022-03-15');
    INSERT INTO CASHIEREPORT (CASHIERNAME, TOTALSELLS, EVALUATION, CREATEDATE) VALUES ('Noah_22', '12400', 'Good', '2022-06-20');
    INSERT INTO CASHIEREPORT (CASHIERNAME, TOTALSELLS, EVALUATION, CREATEDATE) VALUES ('Oliver_22', '18900', 'Excellent', '2022-08-10');
    INSERT INTO CASHIEREPORT (CASHIERNAME, TOTALSELLS, EVALUATION, CREATEDATE) VALUES ('Emma_22', '9500', 'Fair', '2022-10-05');
    INSERT INTO CASHIEREPORT (CASHIERNAME, TOTALSELLS, EVALUATION, CREATEDATE) VALUES ('Ava_22', '21000', 'Outstanding', '2022-12-25');

    -- 2023 Data
    INSERT INTO CASHIEREPORT (CASHIERNAME, TOTALSELLS, EVALUATION, CREATEDATE) VALUES ('James_23', '14000', 'Good', '2023-01-12');
    INSERT INTO CASHIEREPORT (CASHIERNAME, TOTALSELLS, EVALUATION, CREATEDATE) VALUES ('Lucas_23', '22500', 'Excellent', '2023-04-18');
    INSERT INTO CASHIEREPORT (CASHIERNAME, TOTALSELLS, EVALUATION, CREATEDATE) VALUES ('Henry_23', '17800', 'Good', '2023-07-22');
    INSERT INTO CASHIEREPORT (CASHIERNAME, TOTALSELLS, EVALUATION, CREATEDATE) VALUES ('Mia_23', '11200', 'Fair', '2023-09-30');
    INSERT INTO CASHIEREPORT (CASHIERNAME, TOTALSELLS, EVALUATION, CREATEDATE) VALUES ('Sophia_23', '25000', 'Outstanding', '2023-11-14');

    -- 2024 Data
    INSERT INTO CASHIEREPORT (CASHIERNAME, TOTALSELLS, EVALUATION, CREATEDATE) VALUES ('Ethan_24', '19300', 'Excellent', '2024-02-10');
    INSERT INTO CASHIEREPORT (CASHIERNAME, TOTALSELLS, EVALUATION, CREATEDATE) VALUES ('Mason_24', '16500', 'Good', '2024-05-25');
    INSERT INTO CASHIEREPORT (CASHIERNAME, TOTALSELLS, EVALUATION, CREATEDATE) VALUES ('Logan_24', '13200', 'Fair', '2024-08-12');
    INSERT INTO CASHIEREPORT (CASHIERNAME, TOTALSELLS, EVALUATION, CREATEDATE) VALUES ('Isabella_24', '28400', 'Outstanding', '2024-10-05');
    INSERT INTO CASHIEREPORT (CASHIERNAME, TOTALSELLS, EVALUATION, CREATEDATE) VALUES ('Amelia_24', '20100', 'Excellent', '2024-12-01');

    -- 2025 Data
    INSERT INTO CASHIEREPORT (CASHIERNAME, TOTALSELLS, EVALUATION, CREATEDATE) VALUES ('Jackson_25', '14800', 'Good', '2025-01-20');
    INSERT INTO CASHIEREPORT (CASHIERNAME, TOTALSELLS, EVALUATION, CREATEDATE) VALUES ('Aiden_25', '23100', 'Excellent', '2025-03-15');
    INSERT INTO CASHIEREPORT (CASHIERNAME, TOTALSELLS, EVALUATION, CREATEDATE) VALUES ('Sebastian_25', '18900', 'Good', '2025-06-10');
    INSERT INTO CASHIEREPORT (CASHIERNAME, TOTALSELLS, EVALUATION, CREATEDATE) VALUES ('Harper_25', '10500', 'Fair', '2025-09-22');
    INSERT INTO CASHIEREPORT (CASHIERNAME, TOTALSELLS, EVALUATION, CREATEDATE) VALUES ('Evelyn_25', '27200', 'Outstanding', '2025-11-30');

    -- 2026 Data
    INSERT INTO CASHIEREPORT (CASHIERNAME, TOTALSELLS, EVALUATION, CREATEDATE) VALUES ('Mateo_26', '31000', 'Outstanding', '2026-01-10');
    INSERT INTO CASHIEREPORT (CASHIERNAME, TOTALSELLS, EVALUATION, CREATEDATE) VALUES ('Wyatt_26', '24500', 'Excellent', '2026-02-14');
    INSERT INTO CASHIEREPORT (CASHIERNAME, TOTALSELLS, EVALUATION, CREATEDATE) VALUES ('Carter_26', '19800', 'Good', '2026-03-05');
    INSERT INTO CASHIEREPORT (CASHIERNAME, TOTALSELLS, EVALUATION, CREATEDATE) VALUES ('Luna_26', '12300', 'Fair', '2026-03-20');
    INSERT INTO CASHIEREPORT (CASHIERNAME, TOTALSELLS, EVALUATION, CREATEDATE) VALUES ('Grace_26', '28700', 'Excellent', '2026-03-25');
    ";

            Execute(conn, query);
        }
        private static void ADMINACC(SqliteConnection conn)
         {
            string query = @"CREATE TABLE IF NOT EXISTS ADMINACC (
                                id INTEGER PRIMARY KEY AUTOINCREMENT,
                                USERNAME TEXT NOT NULL UNIQUE,
                                PASSWORD TEXT NOT NULL
                            );";
            Execute(conn, query);

        }
        private static void CASHIERACC(SqliteConnection conn)
        {
            string query = @"CREATE TABLE IF NOT EXISTS CASHIERACC (
                                id INTEGER PRIMARY KEY AUTOINCREMENT,
                                ADMINUSERNAME TEXT NOT NULL,
                                USERNAME TEXT NOT NULL UNIQUE,
                                PASSWORD TEXT NOT NULL
                            );";
            Execute(conn, query);

        }
        private static void PRODUCTS(SqliteConnection conn)
        {
            string query = @"CREATE TABLE IF NOT EXISTS PRODUCTS (
                        id INTEGER ,
                       
                        ADMINNAME TEXT NOT NULL,
                        PRODUCTIMAGE BLOB,
                        PRODUCTNAME TEXT NOT NULL,
                        PRODUCTPRICE TEXT NOT NULL
                       
                    );";
            Execute(conn, query);
        }
        private static void ADDSON(SqliteConnection conn)
        {
            string query = @"CREATE TABLE IF NOT EXISTS ADDSON (
                        id INTEGER ,
                       
                        ADMINNAME TEXT NOT NULL,
                        ADDSONTIMAGE BLOB,
                        ADDSONNAME TEXT NOT NULL,
                        ADDSONPRICE TEXT NOT NULL
                       
                    );";
            Execute(conn, query);
        }
        private static void CASHIERSELLS(SqliteConnection conn)
        {
            string query = @"CREATE TABLE IF NOT EXISTS CASHIERSELLS (
        CASHIERNAME TEXT NOT NULL,
        CUSTOMERNAME TEXT NOT NULL,
        ORDERID TEXT NOT NULL,
        PAYMENTMETHOD TEXT NOT NULL,
        ORDERTOTAL TEXT NOT NULL,
        CUSTOMERMONEY TEXT NOT NULL,
        CUSTOMERCHANGE TEXT NOT NULL,
        CREATEDATE TEXT NOT NULL
    );";

            Execute(conn, query);
        }
        private static void CASHIEREPORT(SqliteConnection conn)
        {
            string query = @"CREATE TABLE IF NOT EXISTS CASHIEREPORT (
                             CASHIERNAME TEXT NOT NULL,
                             TOTALSELLS TEXT NOT NULL,
                              EVALUATION TEXT NOT NULL,
                              CREATEDATE TEXT NOT NULL
                            
                         );";
            Execute(conn, query);
        }

        private static void Execute(SqliteConnection conn, string query)
        {
            using (var cmd = new SqliteCommand(query, conn))
            {
                cmd.ExecuteNonQuery();
            }
        }


    }
}
