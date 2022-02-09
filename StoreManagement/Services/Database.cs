using StoreManagement.Model;
using StoreManagement.Xml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreManagement.Services
{
   public class GetKey
    {
        protected private string Key { get => "ArabSoftware"; }
        public string getKey() 
        {
            return Key;
        }
       
    }
    public static class Database
    {
        
        private static string _ConnectionString;
        private static string ConnectionString { get=> _ConnectionString; }
        public static string GetConeectionString(string key)
        {
            GetKey k = new GetKey();
            if (k.getKey() == key) return ConnectionString;
            else return "";
        }
        
        #region Products
        private static BindingList<Product> _Products;
        public static BindingList<Product> Products { get
            {
                if (_Products == null)
                {
                    _Products = new BindingList<Product>(new XMLProductSerilaizer().ReadProduct());
                    //_Products = new BindingList<Product>()
                    //{
                    //    new Product()
                    //    {
                    //       ID =1,
                    //       Name = "Pork",
                    //       quantity=200,
                    //       UnitID = 2,
                    //       BuyPrice = 5.0,
                    //       descritption = "",
                    //       SellPrice = 6.0,

                    //    } ,
                    //    new Product()
                    //    {
                    //       ID =2,
                    //       Name = "Chicken",
                    //       UnitID = 2,
                    //       BuyPrice = 4.0,
                    //       descritption = "",
                    //       SellPrice = 5.0,

                    //    } ,

                    //    new Product()
                    //    {
                    //       ID =3,
                    //       Name = "Turkey",
                    //       UnitID = 2,
                    //       BuyPrice = 10.0,
                    //       descritption = "",
                    //       SellPrice = 15.0,

                    //    } ,
                    //    new Product()
                    //    {
                    //       ID =4,
                    //       Name = "Beef",
                    //       UnitID = 2,
                    //       BuyPrice = 8.0,
                    //       descritption = "",
                    //       SellPrice = 10.0,

                    //    } ,

                    //    new Product()
                    //    {
                    //       ID =5,
                    //       Name = "Lamp",
                    //       UnitID = 2,
                    //       BuyPrice = 5.0,
                    //       descritption = "",
                    //       SellPrice = 6.0,
                    //    } ,
                    //    new Product()
                    //    {
                    //       ID =6,
                    //       Name = "White Bread",
                    //       UnitID = 3,
                    //       BuyPrice = 5.0,
                    //       descritption = "",
                    //       SellPrice = 6.0,
                    //    } ,
                    //    new Product()
                    //    {
                    //       ID =7,
                    //       Name = "baguette",
                    //       UnitID = 3,
                    //       BuyPrice = 5.0,
                    //       descritption = "",
                    //       SellPrice = 6.0,
                    //    } ,
                    //    new Product()
                    //    {
                    //       ID =8,
                    //       Name = "Ciabatte",
                    //       UnitID = 3,
                    //       BuyPrice = 5.0,
                    //       descritption = "",
                    //       SellPrice = 6.0,
                    //    } ,
                    //    new Product()
                    //    {
                    //       ID =9,
                    //       Name = "Corn Bread",
                    //       UnitID = 3,
                    //       BuyPrice = 5.0,
                    //       descritption = "",
                    //       SellPrice = 6.0,
                    //    } ,
                    //     new Product()
                    //    {
                    //       ID =10,
                    //       Name = "Mulligrain Bread",
                    //       UnitID = 3,
                    //       BuyPrice = 5.0,
                    //       descritption = "",
                    //       SellPrice = 6.0,
                    //    } ,                      
                    //    new Product()
                    //    {
                    //       ID =11,
                    //       Name = "Buter Cake",
                    //       UnitID = 4,
                    //       BuyPrice = 5.0,
                    //       descritption = "",
                    //       SellPrice = 6.0,
                    //    } , 
                    //    new Product()
                    //    {
                    //       ID =12,
                    //       Name = "Pound cake ",
                    //       UnitID = 4,
                    //       BuyPrice = 5.0,
                    //       descritption = "",
                    //       SellPrice = 6.0,
                    //    } ,
                    //    new Product()
                    //    {
                    //       ID =13,
                    //       Name = "Sponge Cake",
                    //       UnitID = 4,
                    //       BuyPrice = 5.0,
                    //       descritption = "",
                    //       SellPrice = 6.0,
                    //    } ,
                    //    new Product()
                    //    {
                    //       ID =14,
                    //       Name = "Biscuit Cake",
                    //       UnitID = 4,
                    //       BuyPrice = 5.0,
                    //       descritption = "",
                    //       SellPrice = 6.0,
                    //    } ,
                    //    new Product()
                    //    {
                    //       ID =15,
                    //       Name = "Carrot Cake",
                    //       UnitID = 4,
                    //       BuyPrice = 5.0,
                    //       descritption = "",
                    //       SellPrice = 6.0,
                    //    } ,
                    //    new Product()
                    //    {
                    //       ID =16,
                    //       Name = "Broccoli",
                    //       UnitID = 5,
                    //       BuyPrice = 5.0,
                    //       descritption = "",
                    //       SellPrice = 6.0,
                    //    } ,
                    //    new Product()
                    //    {
                    //       ID =17,
                    //       Name = "Potato",
                    //       UnitID = 5,
                    //       BuyPrice = 5.0,
                    //       descritption = "",
                    //       SellPrice = 6.0,
                    //    } ,
                    //    new Product()
                    //    {
                    //       ID =18,
                    //       Name = "Cucumber",
                    //       UnitID = 5,
                    //       BuyPrice = 5.0,
                    //       descritption = "",
                    //       SellPrice = 6.0,
                    //    } ,
                    //    new Product()
                    //    {
                    //       ID =19,
                    //       Name = "Zucchini",
                    //       UnitID = 5,
                    //       BuyPrice = 5.0,
                    //       descritption = "",
                    //       SellPrice = 6.0,
                    //    } ,
                    //    new Product()
                    //    {
                    //       ID =20,
                    //       Name = "Union",
                    //       UnitID = 5,
                    //       BuyPrice = 5.0,
                    //       descritption = "",
                    //       SellPrice = 6.0,
                    //    } ,
                    //    new Product()
                    //    {
                    //       ID =21,
                    //       Name = "Apples",
                    //       UnitID = 6,
                    //       BuyPrice = 5.0,
                    //       descritption = "",
                    //       SellPrice = 6.0,
                    //    } ,
                    //    new Product()
                    //    {
                    //       ID =22,
                    //       Name = "Banana",
                    //       UnitID = 6,
                    //       BuyPrice = 5.0,
                    //       descritption = "",
                    //       SellPrice = 6.0,
                    //    } ,
                    //    new Product()
                    //    {
                    //       ID =23,
                    //       Name = "Watermelone",
                    //       UnitID = 6,
                    //       BuyPrice = 5.0,
                    //       descritption = "",
                    //       SellPrice = 6.0,
                    //    } ,
                    //    new Product()
                    //    {
                    //       ID =24,
                    //       Name = "Peaches",
                    //       UnitID = 6,
                    //       BuyPrice = 5.0,
                    //       descritption = "",
                    //       SellPrice = 6.0,
                    //    } ,
                    //    new Product()
                    //    {
                    //       ID =25,
                    //       Name = "Kiwi",
                    //       UnitID = 6,
                    //       BuyPrice = 5.0,
                    //       descritption = "",
                    //       SellPrice = 6.0,
                    //    } ,
                    //      new Product()
                    //    {
                    //       ID =26,
                    //       Name = "Mineral water",
                    //       UnitID = 8,
                    //       BuyPrice = 5.0,
                    //       descritption = "",
                    //       SellPrice = 6.0,
                    //    } ,  new Product()
                    //    {
                    //       ID =27,
                    //       Name = "Spring Water",
                    //       UnitID = 8,
                    //       BuyPrice = 5.0,
                    //       descritption = "",
                    //       SellPrice = 6.0,
                    //    } ,  new Product()
                    //    {
                    //       ID =28,
                    //       Name = "Distilled Water",
                    //       UnitID =8,
                    //       BuyPrice = 5.0,
                    //       descritption = "",
                    //       SellPrice = 6.0,
                    //    } ,  new Product()
                    //    {
                    //       ID =29,
                    //       Name = "Flavored Water",
                    //       UnitID = 8,
                    //       BuyPrice = 5.0,
                    //       descritption = "",
                    //       SellPrice = 6.0,
                    //    } ,  new Product()
                    //    {
                    //       ID =30,
                    //       Name = "Alkaline Water",
                    //       UnitID = 8,
                    //       BuyPrice = 5.0,
                    //       descritption = "",
                    //       SellPrice = 6.0,
                    //    } ,
                    //         new Product()
                    //    {
                    //       ID =31,
                    //       Name = "Cold Tea",
                    //       UnitID = 9,
                    //       BuyPrice = 5.0,
                    //       descritption = "",
                    //       SellPrice = 6.0,
                    //    } ,
                    //};
                }
                return _Products; } set { _Products = value; } }

        private static BindingList<Unites> _Units;
        public static BindingList<Unites> Units
        {
            get
            {
                if (_Units == null)
                {
                    _Units = new BindingList<Unites>(new XMLUnitesSerializer().ReadUnite());
                    //_Units = new BindingList<Unites>()
                    //    {
                    //        new Unites() 
                    //        {
                    //            ID = 1,
                    //            Name = "Food",
                    //            PerantID = 0,
                    //        } ,
                    //         new Unites()
                    //        {
                    //            ID = 2,
                    //            Name = "Meat",
                    //            PerantID = 1,
                    //        } ,
                    //          new Unites()
                    //        {
                    //            ID = 3,
                    //            Name = "Bread",
                    //            PerantID = 1,
                    //        } ,  

                    //        new Unites()
                    //        {
                    //            ID = 4,
                    //            Name = "Cakes",
                    //            PerantID = 1,
                    //        } , 
                             
                    //        new Unites()
                    //        {
                    //            ID = 5,
                    //            Name = "Vegetables",
                    //            PerantID = 1,
                    //        } ,
                    //        new Unites()
                    //        {
                    //            ID = 6,
                    //            Name = "Fruits",
                    //            PerantID = 1,
                    //        } ,

                    //         new Unites()
                    //        {
                    //            ID = 7,
                    //            Name = "Drinks",
                    //            PerantID = 0,
                    //        } ,  new Unites()
                    //        {
                    //            ID = 8,
                    //            Name = "Watter",
                    //            PerantID = 7,
                    //        } ,  new Unites()
                    //        {
                    //            ID = 9,
                    //            Name = "Tea",
                    //            PerantID = 7,
                    //        } ,  new Unites()
                    //        {
                    //            ID = 10,
                    //            Name = "Soft Drinks",
                    //            PerantID = 7,
                    //        } ,  new Unites()
                    //        {
                    //            ID = 11,
                    //            Name = "Wine",
                    //            PerantID = 7,
                    //        } ,  new Unites()
                    //        {
                    //            ID = 11,
                    //            Name = "Beer",
                    //            PerantID = 7,
                    //        } ,
                    //    };
                }
                return _Units;
            }
            set { _Units = value; }
        }
        #endregion

        #region Users
        private static BindingList<User> _Users;
        public static BindingList<User> Users
        {
            get
            {
                if (_Users == null)
                {
                    _Users = new BindingList<User>( new XMLUserSerilaizer().ReadUsers());
                    //_Users = new BindingList<User>()
                    //{
                    //    new User()
                    //    {
                    //        ID = 1,
                    //        FullName = "Mohamed Ali",
                    //        UserName = "Mohamed",
                    //        Password = "123",
                    //        IsActive = true,
                    //        UserType = (int)Master.UserType.Admin,
                    //    } ,
                    //     new User()
                    //    {
                    //        ID = 2,
                    //        FullName = "Mohamed Hammad",
                    //        UserName = "Hammad",
                    //        Password = "123",
                    //        IsActive = true,
                    //        UserType = (int)Master.UserType.User,
                    //    } ,
                    //};
                }return _Users;
              
                
            }
            set { _Users = value; }
        }

        private static BindingList<UserAccess> _UserAccess;
        public static BindingList<UserAccess> UserAccess
        {
            get
            {
                if (_UserAccess == null)
                {
                    _UserAccess = new BindingList<UserAccess>( new XMLAccessUserSerializer().ReadInvoiceDetails() );
                    //_UserAccess = new BindingList<UserAccess>()
                    //{
                    //    new UserAccess() {ID = 1,AccessName = "Add Products",Value = false,UserID = 2 } ,
                    //    new UserAccess() {ID = 2,AccessName = "Delete Products",Value = false,UserID = 2 } ,
                    //};
                }
                return _UserAccess;
            }
            set { _UserAccess = value; }
        }
        #endregion

        #region Invoices

        private static BindingList<InvoiceHeader> _InvoiceHeader;
        public static BindingList<InvoiceHeader> InvoiceHeader
        {
            get
            {
                if (_InvoiceHeader == null)
                {
                  _InvoiceHeader = new BindingList<InvoiceHeader>( new XMLInvoiceHeaderSerializer().ReadInvoiceHeader());
                }
                return _InvoiceHeader;
            }
            set { _InvoiceHeader = value; }
        }

        private static BindingList<InvoiceDetails> _InvoiceDetails;
        public static BindingList<InvoiceDetails> InvoiceDetails
        {
            get
            {
                if (_InvoiceDetails == null)
                {
                    _InvoiceDetails = new BindingList<InvoiceDetails>( new XMLInvoiceDetailsSerializer().ReadInvoiceDetails());
                }
                return _InvoiceDetails;
            }
            set { _InvoiceDetails = value; }
        }
        #endregion
    }
}

