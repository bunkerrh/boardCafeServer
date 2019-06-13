using BoardCafeServer.Objects;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BoardCafeServer.Areas.BoardCafeAreas.DBConnections
{
    public class BoardCafeMySqlUtil
    {

        private String SELECT_ALL_CAFE_ITEMS = "SELECT ITEM_ID, ITEM_NAME, ITEM_DESC, ITEM_PRICE, SHELLFISH_FLG, PEANUT_FLG, GLUTEN_FLG FROM CAFE_MENU_ITEM;";

        public static String myConnectionString = "Server=localhost;Database=board_cafe;Uid=boardAdmin;Pwd=password;";

        public MySqlConnection connection = new MySqlConnection(myConnectionString);
        MySqlCommand cmd;

        public List<CafeMenuItem> selectAllCafeItems()
        {
            List<CafeMenuItem> cafeItems = new List<CafeMenuItem>();

            connection.Open();
            cmd = connection.CreateCommand();
            cmd.CommandText = SELECT_ALL_CAFE_ITEMS;

            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                CafeMenuItem item = new CafeMenuItem();

                item.itemId = reader.GetInt32(0);
                item.itemName = reader.GetString(1);
                item.itemDesc = reader.GetString(2);
                item.itemPrice = reader.GetDouble(3);
                item.peanut = reader.GetBoolean(4);
                item.shellfish = reader.GetBoolean(5);
                item.gluten = reader.GetBoolean(6);

                cafeItems.Add(item);

            }
            return cafeItems;
        }

    }
}



