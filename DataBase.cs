using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data.Linq;
using System.Data.Linq.Mapping;

namespace Apteka
{
    public class DataBase : DataContext
    {
        public DataBase(string path)
            : base(path) { }
        public Table<Algoritm> Algoritm;
        public Table<Card> Card;
        public Table<Custom> Custom;
        public Table<Preparation> Preparation;
        public Table<Purchase> Purchase;
        public Table<Sale> Sale;
        public Table<Setup> Setup;
        public Table<Supplier> Supplier;

        public void ADD_Algoritm(float summa, int procent)
        {
            Algoritm a = new Algoritm();
            a.summa = summa;
            a.procent = procent;
            this.Algoritm.InsertOnSubmit(a);
            this.SubmitChanges();
        }
        public void ADD_Card(int id_algoritm, float save_summa)
        {
            Card a = new Card();
            a.id_algoritm = id_algoritm;
            a.save_summa = save_summa;
            this.Card.InsertOnSubmit(a);
            this.SubmitChanges();
        }
        public void ADD_Custom(int id_preparation, int id_supplier, int amount, DateTime data_send)
        {
            Custom a = new Custom();
            a.id_preparation = id_preparation;
            a.id_supplier = id_supplier;
            a.amount = amount;
            a.data_send = data_send;
            this.Custom.InsertOnSubmit(a);
            this.SubmitChanges();
        }
        public void ADD_Preparation(int id_supplier, int id_setup, string name, int amount, float price, string gruppa)
        {
            Preparation a = new Preparation();
            a.id_supplier = id_supplier;
            a.id_setup = id_setup;
            a.name = name;
            a.amount = amount;
            a.price = price;
            a.gruppa = gruppa;
            this.Preparation.InsertOnSubmit(a);
            this.SubmitChanges();
        }
        public void ADD_Purchase(int id_supplier, int id_preparation, int amount, float price, DateTime date_come)
        {
            Purchase a = new Purchase();
            a.id_supplier = id_supplier;
            a.id_preparation = id_preparation;
            a.amount = amount;
            a.price = price;
            a.date_come = date_come;
            this.Purchase.InsertOnSubmit(a);
            this.SubmitChanges();
        }
        public void ADD_Sale(int id_preparation, int id_card, int amount, float price, DateTime date_sale)
        {
            Sale a = new Sale();
            a.id_preparation = id_preparation;
            a.id_card = id_card;
            a.amount = amount;
            a.price = price;
            a.date_sale = date_sale;
            this.Sale.InsertOnSubmit(a);
            this.SubmitChanges();
        }
        public void ADD_Setup(DateTime srok, int porog)
        {
            Setup a = new Setup();

            a.srok = srok;
            a.porog = porog;
            this.Setup.InsertOnSubmit(a);
            this.SubmitChanges();
        }
        public void ADD_Supplier(string name, string email, int inn)
        {
            Supplier a = new Supplier();

            a.name = name;
            a.email = email;
            a.inn = inn;
            this.Supplier.InsertOnSubmit(a);
            this.SubmitChanges();
        }

        public void Delete_Algoritm(int id)
        {
            var query = from h in this.Algoritm where h.id_algoritm == id select h;
            List<Object> list = new List<object>();
            foreach (Object q in query)
            {
                list.Add(q);
                foreach (Object l in list)
                {
                    this.Algoritm.DeleteOnSubmit(l as Algoritm);
                }
                this.SubmitChanges();
            }
        }
        public void Delete_Card(int id)
        {
            var query = from h in this.Card where h.id_card == id select h;
            List<Object> list = new List<object>();
            foreach (Object q in query)
            {
                list.Add(q);
                foreach (Object l in list)
                {
                    this.Card.DeleteOnSubmit(l as Card);
                }
                this.SubmitChanges();
            }
        }
        public void Delete_Custom(int id)
        {
            var query = from h in this.Custom where h.id_custom == id select h;
            List<Object> list = new List<object>();
            foreach (Object q in query)
            {
                list.Add(q);
                foreach (Object l in list)
                {
                    this.Custom.DeleteOnSubmit(l as Custom);
                }
                this.SubmitChanges();
            }
        }
        public void Delete_Preparation(int id)
        {
            var query = from h in this.Preparation where h.id_preparation == id select h;
            List<Object> list = new List<object>();
            foreach (Object q in query)
            {
                list.Add(q);
                foreach (Object l in list)
                {
                    this.Preparation.DeleteOnSubmit(l as Preparation);
                }
                this.SubmitChanges();
            }
        }
        public void Delete_Purchase(int id)
        {
            var query = from h in this.Purchase where h.id_purchase == id select h;
            List<Object> list = new List<object>();
            foreach (Object q in query)
            {
                list.Add(q);
                foreach (Object l in list)
                {
                    this.Purchase.DeleteOnSubmit(l as Purchase);
                }
                this.SubmitChanges();
            }
        }
        public void Delete_Sale(int id)
        {
            var query = from h in this.Sale where h.id_sale == id select h;
            List<Object> list = new List<object>();
            foreach (Object q in query)
            {
                list.Add(q);
                foreach (Object l in list)
                {
                    this.Sale.DeleteOnSubmit(l as Sale);
                }
                this.SubmitChanges();
            }
        }
        public void Delete_Setup(int id)
        {
            var query = from h in this.Setup where h.id_setup == id select h;
            List<Object> list = new List<object>();
            foreach (Object q in query)
            {
                list.Add(q);
                foreach (Object l in list)
                {
                    this.Setup.DeleteOnSubmit(l as Setup);
                }
                this.SubmitChanges();
            }
        }
        public void Delete_Supplier(int id)
        {
            var query = from h in this.Supplier where h.id_supplier == id select h;
            List<Object> list = new List<object>();
            foreach (Object q in query)
            {
                list.Add(q);
                foreach (Object l in list)
                {
                    this.Supplier.DeleteOnSubmit(l as Supplier);
                }
                this.SubmitChanges();
            }
        }

        public void Delete_AllAlgoritm()
        {
            var query = from h in this.Algoritm select h;
            List<Object> list = new List<object>();
            foreach (Object q in query)
            {
                list.Add(q);
                foreach (Object l in list)
                {
                    this.Algoritm.DeleteOnSubmit(l as Algoritm);
                }
                this.SubmitChanges();
            }
        }
        public void Delete_AllCard()
        {
            var query = from h in this.Card select h;
            List<Object> list = new List<object>();
            foreach (Object q in query)
            {
                list.Add(q);
                foreach (Object l in list)
                {
                    this.Card.DeleteOnSubmit(l as Card);
                }
                this.SubmitChanges();
            }
        }
        public void Delete_AllCustom()
        {
            var query = from h in this.Custom select h;
            List<Object> list = new List<object>();
            foreach (Object q in query)
            {
                list.Add(q);
                foreach (Object l in list)
                {
                    this.Custom.DeleteOnSubmit(l as Custom);
                }
                this.SubmitChanges();
            }
        }
        public void Delete_AllPreparation()
        {
            var query = from h in this.Preparation select h;
            List<Object> list = new List<object>();
            foreach (Object q in query)
            {
                list.Add(q);
                foreach (Object l in list)
                {
                    this.Preparation.DeleteOnSubmit(l as Preparation);
                }
                this.SubmitChanges();
            }
        }
        public void Delete_AllPurchase()
        {
            var query = from h in this.Purchase select h;
            List<Object> list = new List<object>();
            foreach (Object q in query)
            {
                list.Add(q);
                foreach (Object l in list)
                {
                    this.Purchase.DeleteOnSubmit(l as Purchase);
                }
                this.SubmitChanges();
            }
        }
        public void Delete_AllSale()
        {
            var query = from h in this.Sale select h;
            List<Object> list = new List<object>();
            foreach (Object q in query)
            {
                list.Add(q);
                foreach (Object l in list)
                {
                    this.Sale.DeleteOnSubmit(l as Sale);
                }
                this.SubmitChanges();
            }
        }
        public void Delete_AllSetup()
        {
            var query = from h in this.Setup select h;
            List<Object> list = new List<object>();
            foreach (Object q in query)
            {
                list.Add(q);
                foreach (Object l in list)
                {
                    this.Setup.DeleteOnSubmit(l as Setup);
                }
                this.SubmitChanges();
            }
        }
        public void Delete_AllSupplier()
        {
            var query = from h in this.Supplier select h;
            List<Object> list = new List<object>();
            foreach (Object q in query)
            {
                list.Add(q);
                foreach (Object l in list)
                {
                    this.Supplier.DeleteOnSubmit(l as Supplier);
                }
                this.SubmitChanges();
            }
        }

        public List<Object> Select_Algoritm() {
            List<Object> list = new List<Object>();
            var query = from h in this.Algoritm select h;
            foreach (var q in query)
            {
                list.Add(q);
            }
            return list;
        }
        public List<Object> Select_Card()
        {
            List<Object> list = new List<Object>();
            var query = from h in this.Card select h;
            foreach (var q in query)
            {
                list.Add(q);
            }
            return list;
        }
        public List<Object> Select_Custom()
        {
            List<Object> list = new List<Object>();
            var query = from h in this.Custom select h;
            foreach (var q in query)
            {
                list.Add(q);
            }
            return list;
        }
        public List<Object> Select_Preparation()
        {
            List<Object> list = new List<Object>();
            var query = from h in this.Preparation select h;
            foreach (var q in query)
            {
                list.Add(q);
            }
            return list;
        }
        public List<Object> Select_Purchase()
        {
            List<Object> list = new List<Object>();
            var query = from h in this.Purchase select h;
            foreach (var q in query)
            {
                list.Add(q);
            }
            return list;
        }
        public List<Object> Select_Sale()
        {
            List<Object> list = new List<Object>();
            var query = from h in this.Sale select h;
            foreach (var q in query)
            {
                list.Add(q);
            }
            return list;
        }
        public List<Object> Select_Setup()
        {
            List<Object> list = new List<Object>();
            var query = from h in this.Setup select h;
            foreach (var q in query)
            {
                list.Add(q);
            }
            return list;
        }
        public List<Object> Select_Supplier()
        {
            List<Object> list = new List<Object>();
            var query = from h in this.Supplier select h;
            foreach (var q in query)
            {
                list.Add(q);
            }
            return list;
        }
    }
        [Table]
        public class Algoritm
        {
            private int Id_algoritm;
            private EntitySet<Card> _Cards;
            [Association(Storage = "_card", OtherKey = "id_algoritm")]
            public EntitySet<Card> Cards
            {
                get { return this._Cards; }
                set
                {
                    this._Cards.Assign(value);
                }
            }
            [Column(IsPrimaryKey = true, IsDbGenerated = true, CanBeNull = false, DbType = "int", Storage = "Id_algoritm")]

            public int id_algoritm
            { get { return this.Id_algoritm; } set { this.Id_algoritm = value; } }

            private float Summa;
            [Column(IsPrimaryKey = false, IsDbGenerated = false, CanBeNull = true, DbType = "float", Storage = "Summa")]

            public float summa
            {
                get
                { return this.Summa; }
                set { this.Summa = value; }
            }

            private int Procent;
            [Column(IsPrimaryKey = false, IsDbGenerated = false, CanBeNull = true, DbType = "int", Storage = "Procent")]

            public int procent
            {
                get { return this.Procent; }
                set { this.Procent = value; }
            }


        }
        [Table]
        public class Card
        {
            private int Id_card;
            private EntityRef<Algoritm> _Algoritm;
            [Association(Storage = "_Algoritm", ThisKey = "id_algoritm")]
            
            [Column(IsPrimaryKey = true, IsDbGenerated = true, CanBeNull = false, DbType = "int", Storage = "Id_card")]
          public Algoritm Algoritm 
            {
                get { return this._Algoritm.Entity; }
                set { this._Algoritm.Entity = value; }
            }
            public int id_card
            {
                get
                { return this.Id_card; }
                set
                { this.Id_card = value; }
            }
            private int Id_algoritm;
            [Column(IsPrimaryKey = false, IsDbGenerated = false, CanBeNull = true, DbType = "int", Storage = "Id_algoritm")]

            public int id_algoritm
            {
                get
                { return this.Id_algoritm; }
                set
                { this.Id_algoritm = value; }
            }
            private float Save_summa;
            [Column(IsPrimaryKey = false, IsDbGenerated = false, CanBeNull = true, DbType = "float", Storage = "Save_summa")]

            public float save_summa
            {
                get
                { return this.Save_summa; }
                set
                { this.Save_summa = value; }
            }

        }
        [Table]
        public class Custom
        {
            private int Id_custom;
            [Column(IsPrimaryKey = true, IsDbGenerated = true, CanBeNull = false, DbType = "int", Storage = "Id_custom")]

            public int id_custom
            {
                get
                { return this.Id_custom; }
                set
                { this.Id_custom = value; }
            }
            private int Id_preparation;
            [Column(IsPrimaryKey = false, IsDbGenerated = false, CanBeNull = true, DbType = "int", Storage = "Id_preparation")]

            public int id_preparation
            {
                get
                { return this.Id_preparation; }
                set
                { this.Id_preparation = value; }
            }
            private int Id_supplier;
            [Column(IsPrimaryKey = false, IsDbGenerated = false, CanBeNull = true, DbType = "int", Storage = "Id_supplier")]

            public int id_supplier
            {
                get
                { return this.Id_supplier; }
                set
                { this.Id_supplier = value; }
            }
            private int Amount;
            [Column(IsPrimaryKey = false, IsDbGenerated = false, CanBeNull = true, DbType = "int", Storage = "Amount")]

            public int amount
            {
                get
                { return this.Amount; }
                set
                { this.Amount = value; }
            }
            private DateTime Data_send;
            [Column(IsPrimaryKey = false, IsDbGenerated = false, CanBeNull = true, DbType = "DateTime", Storage = "Data_send")]

            public DateTime data_send
            {
                get
                { return this.Data_send; }
                set
                { this.Data_send = value; }
            }

        }
        [Table]
        public class Preparation
        {
            private int Id_preparation;
            [Column(IsPrimaryKey = true, IsDbGenerated = true, CanBeNull = false, DbType = "int", Storage = "Id_preparation")]

            public int id_preparation
            {
                get
                { return this.Id_preparation; }
                set
                { this.Id_preparation = value; }
            }

            private int Id_supplier;
            [Column(IsPrimaryKey = false, IsDbGenerated = false, CanBeNull = true, DbType = "int", Storage = "Id_supplier")]

            public int id_supplier
            {
                get
                { return this.Id_supplier; }
                set
                { this.Id_supplier = value; }
            }
            private int Id_setup;
            [Column(IsPrimaryKey = false, IsDbGenerated = false, CanBeNull = true, DbType = "int", Storage = "Id_setup")]

            public int id_setup
            {
                get
                { return this.Id_setup; }
                set
                { this.Id_setup = value; }
            }
            private string Name;
            [Column(IsPrimaryKey = false, IsDbGenerated = false, CanBeNull = true, DbType = "varchar", Storage = "Name")]

            public string name
            {
                get
                { return this.Name; }
                set
                { this.Name = value; }
            }
            private int Amount;
            [Column(IsPrimaryKey = false, IsDbGenerated = false, CanBeNull = true, DbType = "int", Storage = "Amount")]

            public int amount
            {
                get
                { return this.Amount; }
                set
                { this.Amount = value; }
            }


            private float Price;
            [Column(IsPrimaryKey = false, IsDbGenerated = false, CanBeNull = true, DbType = "float", Storage = "Price")]

            public float price
            {
                get
                { return this.Price; }
                set { this.Price = value; }
            }

            private string Gruppa;
            [Column(IsPrimaryKey = false, IsDbGenerated = false, CanBeNull = true, DbType = "varchar", Storage = "Gruppa")]

            public string gruppa
            {
                get
                { return this.Gruppa; }
                set
                { this.Gruppa = value; }
            }
        }
        [Table]
        public class Purchase
        {
            private int Id_purchase;
            [Column(IsPrimaryKey = true, IsDbGenerated = true, CanBeNull = false, DbType = "int", Storage = "Id_purchase")]

            public int id_purchase
            {
                get
                { return this.Id_purchase; }
                set
                { this.Id_purchase = value; }
            }
            private int Id_preparation;
            [Column(IsPrimaryKey = false, IsDbGenerated = false, CanBeNull = true, DbType = "int", Storage = "Id_preparation")]

            public int id_preparation
            {
                get
                { return this.Id_preparation; }
                set
                { this.Id_preparation = value; }
            }
            private int Id_supplier;
            [Column(IsPrimaryKey = false, IsDbGenerated = false, CanBeNull = true, DbType = "int", Storage = "Id_supplier")]

            public int id_supplier
            {
                get
                { return this.Id_supplier; }
                set
                { this.Id_supplier = value; }
            }
            private int Amount;
            [Column(IsPrimaryKey = false, IsDbGenerated = false, CanBeNull = true, DbType = "int", Storage = "Amount")]

            public int amount
            {
                get
                { return this.Amount; }
                set
                { this.Amount = value; }
            }

            private float Price;
            [Column(IsPrimaryKey = false, IsDbGenerated = false, CanBeNull = true, DbType = "float", Storage = "Price")]

            public float price
            {
                get
                { return this.Price; }
                set { this.Price = value; }
            }

            private DateTime Date_come;
            [Column(IsPrimaryKey = false, IsDbGenerated = false, CanBeNull = true, DbType = "DateTime", Storage = "Date_come")]

            public DateTime date_come
            {
                get
                { return this.Date_come; }
                set
                { this.Date_come = value; }
            }

        }
        [Table]
        public class Sale
        {
            private int Id_sale;
            [Column(IsPrimaryKey = true, IsDbGenerated = true, CanBeNull = false, DbType = "int", Storage = "Id_sale")]

            public int id_sale
            {
                get
                { return this.Id_sale; }
                set
                { this.Id_sale = value; }
            }
            private int Id_preparation;
            [Column(IsPrimaryKey = false, IsDbGenerated = false, CanBeNull = true, DbType = "int", Storage = "Id_preparation")]

            public int id_preparation
            {
                get
                { return this.Id_preparation; }
                set
                { this.Id_preparation = value; }
            }
            private int Id_card;
            [Column(IsPrimaryKey = false, IsDbGenerated = false, CanBeNull = true, DbType = "int", Storage = "Id_card")]

            public int id_card
            {
                get
                { return this.Id_card; }
                set
                { this.Id_card = value; }
            }
            private int Amount;
            [Column(IsPrimaryKey = false, IsDbGenerated = false, CanBeNull = true, DbType = "int", Storage = "Amount")]

            public int amount
            {
                get
                { return this.Amount; }
                set
                { this.Amount = value; }
            }

            private float Price;
            [Column(IsPrimaryKey = false, IsDbGenerated = false, CanBeNull = true, DbType = "float", Storage = "Price")]

            public float price
            {
                get
                { return this.Price; }
                set { this.Price = value; }
            }

            private DateTime Date_sale;
            [Column(IsPrimaryKey = false, IsDbGenerated = false, CanBeNull = true, DbType = "DateTime", Storage = "Date_sale")]

            public DateTime date_sale
            {
                get
                { return this.Date_sale; }
                set
                { this.Date_sale = value; }
            }
        }
        [Table]
        public class Setup
        {
            private int Id_setup;
            [Column(IsPrimaryKey = true, IsDbGenerated = true, CanBeNull = false, DbType = "int", Storage = "Id_setup")]

            public int id_setup
            {
                get
                { return this.Id_setup; }
                set
                { this.Id_setup = value; }
            }
            private DateTime Srok;
            [Column(IsPrimaryKey = false, IsDbGenerated = false, CanBeNull = true, DbType = "DateTime", Storage = "Srok")]

            public DateTime srok
            {
                get
                { return this.Srok; }
                set
                { this.Srok = value; }
            }

            private int Porog;
            [Column(IsPrimaryKey = false, IsDbGenerated = false, CanBeNull = true, DbType = "int", Storage = "Porog")]

            public int porog
            {
                get
                { return this.Porog; }
                set
                { this.Porog = value; }
            }

        }
        [Table]
        public class Supplier
        {
            private int Id_supplier;
            [Column(IsPrimaryKey = true, IsDbGenerated = true, CanBeNull = false, DbType = "int", Storage = "Id_supplier")]

            public int id_supplier
            {
                get
                { return this.Id_supplier; }
                set
                { this.Id_supplier = value; }
            }

            private string Name;
            [Column(IsPrimaryKey = false, IsDbGenerated = false, CanBeNull = true, DbType = "varchar", Storage = "Name")]

            public string name
            {
                get
                { return this.Name; }
                set
                { this.Name = value; }
            }
            private string Email;
            [Column(IsPrimaryKey = false, IsDbGenerated = false, CanBeNull = true, DbType = "varchar", Storage = "Email")]

            public string email
            {
                get
                { return this.Email; }
                set
                { this.Email = value; }
            }

            private int INN;
            [Column(IsPrimaryKey = false, IsDbGenerated = false, CanBeNull = true, DbType = "int", Storage = "INN")]

            public int inn
            {
                get
                { return this.INN; }
                set
                { this.INN = value; }
            }

        }
    }
    
