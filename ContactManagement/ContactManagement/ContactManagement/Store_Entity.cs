using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Collections.ObjectModel;
using ContactManagement;
using ContactManagement.ViewModels;
using System;
using System.ComponentModel;

namespace ContactManagement
{
    public class Store_Entity
    {
        public bool hasError = false;
        public string errorMessage;
        
        public MyObservableCollection<Product> GetProducts()
        {
            hasError = false;
            MyObservableCollection<Product> products = new MyObservableCollection<Product>();
            try
            {
                ContactDBEntities3 db = new ContactDBEntities3();
                var query = from q in db.Contacts
                            select new SqlProduct
                            {
                                ContactID = q.ContactID,
                                FirstName  = q.FirstName,
                                LastName=q.LastName,
                                EmailID = q.EmailID,
                                PhNo=q.PhNo,
                                State = q.State,
                                City = q.City
                            };
   

                foreach (SqlProduct sp in query)
                    // products.Add(sp.SqlProduct2Product());
                    products.Add(sp.SqlProduct2Product());
            } //try
            catch (Exception ex)
            {
                errorMessage = "GetProducts() error, " + ex.Message;
                hasError = true;
            }
            return products;
        } //GetProducts()


        public bool UpdateProduct(Product displayP,int contactId)
        {
            try
            {
                SqlProduct p1 = new SqlProduct(displayP);
                ContactDBEntities3 db = new ContactDBEntities3();
                Contact con = db.Contacts.SingleOrDefault(p => p.ContactID  == contactId);
                con.FirstName = p1.FirstName;
                con.LastName = p1.LastName;
                con.EmailID = p1.EmailID;
                con.PhNo = p1.PhNo;
                con.State = p1.State;
                con.City = p1.City;
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                errorMessage = "Update error, " + ex.Message;
                hasError = true;
            }
            return (!hasError);
        } //UpdateProduct()




        public bool DeleteProduct(int contactId)
        {
            hasError = false;
            try
            {
                ContactDBEntities3 db = new ContactDBEntities3();
                Contact con = db.Contacts.SingleOrDefault(p => p.ContactID == contactId);

                db.Contacts.Remove(con);
                db.SaveChanges();

            }
            catch (Exception ex)
            {
                errorMessage = "Delete error, " + ex.Message;
                hasError = true;
            }
            return !hasError;
        }// DeleteProduct()



        public bool AddProduct(Product displayP)
        {
            hasError = false;
            try
            {
                SqlProduct p = new SqlProduct(displayP);
               
                int? newProductId = 0;
                ContactDBEntities3 db = new ContactDBEntities3();
               
                Contact e = new Contact() {FirstName  = p.FirstName,LastName=p.LastName , EmailID = p.EmailID, State = p.State, City = p.City,PhNo=p.PhNo  };
                // e.Vacations.Add(v);
                db.Contacts.Add(e);
                db.SaveChanges();

                p.ContactID  =1;
                displayP.ProductAdded2DB(p);    //update corresponding Product ProductId using SqlProduct
            }
            catch (Exception ex)
            {
                errorMessage = "Add error, " + ex.Message;
                hasError = true;
            }
            return !hasError;
        } //AddProduct()

    }
}

