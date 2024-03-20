using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Good_Food.SqlHelper
{
    class FoodItem
    {
        public string Denumire { get; set; }
        public int Pret { get; set; }
        public int Fel {  get; set; }
        public int Kcal { get; set; }

        public static List<FoodItem> foodItems;

        public FoodItem(string denumire, int pret, int kcal, int fel)
        {

            Denumire = denumire;
            Pret = pret;
            Kcal = kcal;
            Fel = fel;
        }
        public static void LoadDataFromFile()
        {
            foodItems = new List<FoodItem>();
            string _path = Access.GetMeniuPath();
            using (StreamReader reader = new StreamReader(_path))
            {
                string line = reader.ReadLine();
                while(reader.Peek()>0) {
                     line = reader.ReadLine();
                    if (string.IsNullOrEmpty(line)) { break; }
                   
                    var split = line.Split(';');
                    string denumire = split[1];
                    int pret = int.Parse(split[3]);
                    int kcal = int.Parse(split[4]);
                    int fel = int.Parse(split[5]);
                    foodItems.Add(new FoodItem(denumire, pret, kcal,fel));
                }
            }
        }
        public static DataTable GenerateCombinations(int budg)
        {
          
            DataTable dt = new DataTable();
            int budget = budg;
            dt.Columns.Add("Felul 1");
            dt.Columns.Add("Felul 2");
            dt.Columns.Add("Felul 3");
            dt.Columns.Add("Total pret");
            dt.Columns.Add("Total calorii");
            for (int i = 0; i < foodItems.Count; i++)
            {
                for (int j =0; j < foodItems.Count; j++)
                {
                    for (int k = 0; k < foodItems.Count; k++)
                    {
                        if (foodItems[i].Fel ==1 && foodItems[j].Fel ==2 && foodItems[k].Fel==3 &&i!=j&&i!=k&&k!=j)
                        {
                            
                            int totalPrice = foodItems[i].Pret + foodItems[j].Pret + foodItems[k].Pret;
                            int totalKcal = foodItems[i].Kcal + foodItems[j].Kcal + foodItems[k].Kcal;

                            if (totalPrice <= budget)
                            {
                           
                                dt.Rows.Add(foodItems[i].Denumire, foodItems[j].Denumire, foodItems[k].Denumire, totalPrice,totalKcal);
                            }
                        }
                    }
                }
            }
            return dt;
        }



    }
}
