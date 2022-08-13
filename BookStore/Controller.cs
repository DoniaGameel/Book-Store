
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;

namespace BookStore
{
    public class Controller
    {
        DBManager dbMan;
       
        public Controller()
        {
            dbMan = new DBManager();
        }


        public void TerminateConnection()
        {
            dbMan.CloseConnection();
        }
       
       
        public DataTable usernames()
        {
            string StoredProcedureName = StoredProcedures.getusernames;
            return dbMan.ExecuteReader(StoredProcedureName,null);
        }
      
        public DataTable usernameadmin()
        {
            string StoredProcedureName = StoredProcedures.getusernameadmin;
            return dbMan.ExecuteReader(StoredProcedureName, null); 
        }
        
        public string passwordofusername(string username)
        {
            string StoredProcedureName = StoredProcedures.passwordofusername;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@username", username);
            return (string)dbMan.ExecuteScalar(StoredProcedureName, Parameters);
        }
        
        public string passwordofusernameadmin(string username)
        {
            string StoredProcedureName = StoredProcedures.passwordofusernameadmin;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@username", username);
            return (string)dbMan.ExecuteScalar(StoredProcedureName, Parameters);
        }
        
        public int signupform(string fname, string lname, string username, string password, string email, string state, string city, string district, string street, string housnumber, string postalnum, string countrycode, string phonenumber)
        {
            string StoredProcedureName = StoredProcedures.signupform;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Fname", fname);
            Parameters.Add("@Lname", lname);
            Parameters.Add("@username", username);
            Parameters.Add("@PW", password);
            Parameters.Add("@email", email);
            Parameters.Add("@stat", state);
            Parameters.Add("@city", city);
            Parameters.Add("@district", district);
            Parameters.Add("@street", district);
            Parameters.Add("@HouseNumber", housnumber);
            Parameters.Add("@postalNumber", postalnum);
            Parameters.Add("@countrycode", countrycode);
            Parameters.Add("@PhoneNumber", phonenumber);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        
        public DataTable takenbooksforspecificuser(string username)
        {
            string StoredProcedureName = StoredProcedures.takenbooksforspecificuser;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@username", username);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }
        public DataTable buyingbooksforspecificuser(string username)
        {
            string StoredProcedureName = StoredProcedures.buyingbooksforspecificuser;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@username", username);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }
        public DataTable borrowingbooksforspecificuser(string username)
        {
            string StoredProcedureName = StoredProcedures.borrowingbooksforspecificuser;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@username", username);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }
        
        public DataTable selectcountofbuyingbooks(string username)
        {
            string StoredProcedureName = StoredProcedures.selectcountofbuyingbooks;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@username", username);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }
        public DataTable selectcountofborrowbooks(string username)
        {
            string StoredProcedureName = StoredProcedures.selectcountofborrowbooks;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@username", username);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }
        public DataTable selectcountoftakebooks(string username)
        {
            string StoredProcedureName = StoredProcedures.selectcountoftakebooks;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@username", username);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }
        public int selectcountbookstosell(string ISBN)
        {
            string StoredProcedureName = StoredProcedures.selectcountbookstosell;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@ISBN", ISBN);
            return (int)dbMan.ExecuteScalar(StoredProcedureName, Parameters);
        }
        public int selectcountbookstolend(string ISBN)
        {
            string StoredProcedureName = StoredProcedures.selectcountbookstolend;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@ISBN", ISBN);
            return (int)dbMan.ExecuteScalar(StoredProcedureName, Parameters);
        }
        public int selectcountbookstodonate(string ISBN)
        {
            string StoredProcedureName = StoredProcedures.selectcountbookstodonate;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@ISBN", ISBN);
            return (int)dbMan.ExecuteScalar(StoredProcedureName, Parameters);
        }
        

        public int selectcountofbuy(string ISBN,string username)
        {
            string StoredProcedureName = StoredProcedures.selectcountofbuy;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@ISBN", ISBN);
            Parameters.Add("@username", username);
            return (int)dbMan.ExecuteScalar(StoredProcedureName, Parameters);
        }
        public int selectcountofborrow(string ISBN, string username)
        {
            string StoredProcedureName = StoredProcedures.selectcountofborrow;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@ISBN", ISBN);
            Parameters.Add("@username", username);
            return (int)dbMan.ExecuteScalar(StoredProcedureName, Parameters);
        }
        public int selectcountoftake(string ISBN, string username)
        {
            string StoredProcedureName = StoredProcedures.selectcountoftake;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@ISBN", ISBN);
            Parameters.Add("@username", username);
            return (int)dbMan.ExecuteScalar(StoredProcedureName, Parameters);
        }

        public int deletebook(string username)
        {
            string StoredProcedureName = StoredProcedures.deletebook;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@username", username);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        public int deleteborrowbook(string username)
        {
            string StoredProcedureName = StoredProcedures.deleteborrowbook;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@username", username);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        public int deletetakebook(string username)
        {
            string StoredProcedureName = StoredProcedures.deletetakebook;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@username", username);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        public int updatecountbookstosell(string ISBN, int count)
        {
            string StoredProcedureName = StoredProcedures.updatecountbookstosell;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@newcount", count);
            Parameters.Add("@ISBN", ISBN);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        public int updatecountbookstolend(string ISBN, int count)
        {
            string StoredProcedureName = StoredProcedures.updatecountbookstolend;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@newcount", count);
            Parameters.Add("@ISBN", ISBN);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        public int updatecountbookstodonate(string ISBN, int count)
        {
            string StoredProcedureName = StoredProcedures.updatecountbookstodonate;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@newcount", count);
            Parameters.Add("@ISBN", ISBN);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        public int updatecountofbooks(string username,int count)
        {
            string StoredProcedureName = StoredProcedures.updatecountofbooks;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@newcount", count);
            Parameters.Add("@username", username);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        
        public int updatecountofborrowbooks(string username, int count)
        {
            string StoredProcedureName = StoredProcedures.updatecountofborrowbooks;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@newcount", count);
            Parameters.Add("@username", username);
            return (int)dbMan.ExecuteScalar(StoredProcedureName, Parameters);
        }
        public int updatecountoftakebooks(string username, int count)
        {
            string StoredProcedureName = StoredProcedures.updatecountoftakebooks;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@newcount", count);
            Parameters.Add("@username", username);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        public int deletebookstosell(string ISBN)
        {
            string StoredProcedureName = StoredProcedures.deletebookstosell;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@ISBN", ISBN);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        public int deletebookstolend(string ISBN)
        {
            string StoredProcedureName = StoredProcedures.deletebookstolend;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@ISBN", ISBN);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        public int deletebookstodonate(string ISBN)
        {
            string StoredProcedureName = StoredProcedures.deletebookstodonate;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@ISBN", ISBN);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        

        public DataTable SelectPblisherID(string Email)
        {
            string StoredProcedureName = StoredProcedures.SelectPublisherID;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Email", Email);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }

        public DataTable SelectAuthorID(string Fname,string Lname ,DateTime DateOfB,string CityOfB ,string Nat ,string Inf)
        {
            string StoredProcedureName = StoredProcedures.SelectAuthorID;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Fname", Fname);
            Parameters.Add("@Lname", Lname);
            Parameters.Add("@DateOfBirth", DateOfB);
            Parameters.Add("@CityOfBirth", CityOfB);
            Parameters.Add("@Nationality", Nat);
            Parameters.Add("@A_Information", Inf);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }
        public int InsertBookToSell(string isbn, string title, string category,string img,int bookcount,int numofpages,string lang,int editionnum,string information,DateTime publishingD,string username,int price)
        {

            string StoredProcedureName = StoredProcedures.InsertBookToSell;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@ISBN", isbn);
            Parameters.Add("@title", title);
            Parameters.Add("@category", category);
            Parameters.Add("@coverphoto", img);
            Parameters.Add("@Bookcount", bookcount);
            Parameters.Add("@numOfPages",numofpages);
            Parameters.Add("@lang",lang);
            Parameters.Add("@editionNum",editionnum);
            Parameters.Add("@information",information);
            Parameters.Add("@PublishingDate",publishingD);
            Parameters.Add("@Username",username);
            Parameters.Add("@price",price);

            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }


        public int InsertBookToDonate(string isbn, string title, string category, string img, int bookcount, int numofpages, string lang, int editionnum, string information, DateTime publishingD, string username)
        {

            string StoredProcedureName = StoredProcedures.InsertBookToDonate;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@ISBN", isbn);
            Parameters.Add("@title", title);
            Parameters.Add("@category", category);
            Parameters.Add("@coverphoto", img);
            Parameters.Add("@Bookcount", bookcount);
            Parameters.Add("@numOfPages", numofpages);
            Parameters.Add("@lang", lang);
            Parameters.Add("@editionNum", editionnum);
            Parameters.Add("@information", information);
            Parameters.Add("@PublishingDate", publishingD);
            Parameters.Add("@Username", username);
            

            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        public int InsertBookToLend(string isbn, string title, string category, string img, int bookcount, int numofpages, string lang, int editionnum, string information, DateTime publishingD, string username, int period)
        {

            string StoredProcedureName = StoredProcedures.InsertBookToLend;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@ISBN", isbn);
            Parameters.Add("@title", title);
            Parameters.Add("@category", category);
            Parameters.Add("@coverphoto", img);
            Parameters.Add("@Bookcount", bookcount);
            Parameters.Add("@numOfPages", numofpages);
            Parameters.Add("@lang", lang);
            Parameters.Add("@editionNum", editionnum);
            Parameters.Add("@information", information);
            Parameters.Add("@PublishingDate", publishingD);
            Parameters.Add("@Username", username);
            Parameters.Add("@pd", period);

            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        public int InsertBookToOrder(string isbn, string title, string category,  int bookcount,string username)
        {

            string StoredProcedureName = StoredProcedures.InsertBookToorder;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@ISBN", isbn);
            Parameters.Add("@title", title);
            Parameters.Add("@category", category);
            Parameters.Add("@Bookcount", bookcount);
            Parameters.Add("@Username", username);
            

            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        public int InsertAuthor(string Fname, string Lname, DateTime DateOfBirth, string CityOfBirth, string Nationality, string A_Information)
        {
            string storedProcedurename = StoredProcedures.InsertAuthor;
            Dictionary<string, object> Parameters=new Dictionary<string,object>();
            Parameters.Add("@Fname",Fname);
            Parameters.Add("@Lname",Lname);
           
            Parameters.Add("@DateOfBirth",DateOfBirth);
            Parameters.Add("@CityOfBirth", CityOfBirth);
            Parameters.Add("@Nationality", Nationality);
            Parameters.Add("@A_Information", A_Information);
            return dbMan.ExecuteNonQuery(storedProcedurename, Parameters);
        }
        public int InsertPublisher( string Publisher_name, string Email, string P_Information, string Fax ,string img)
       
        {
            string storedProcedurename = StoredProcedures.InsertPublisher;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            
            Parameters.Add("@Publisher_name", Publisher_name);
            Parameters.Add("@Email", Email);
            Parameters.Add("@P_Information", P_Information);
            Parameters.Add("@Fax", Fax);
            Parameters.Add("@Logo", img);
            return dbMan.ExecuteNonQuery(storedProcedurename, Parameters);
        }
        public int InsertPublisherAddress(int pid,string state,string distinct,string city,string street,int hn)
        {
            string storedProcedurename = StoredProcedures.InsertPublisherAddress;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@P_ID", pid);
            Parameters.Add("@P_State", state);
            Parameters.Add("@P_City", city);
            Parameters.Add("@P_Distinct", distinct);
            Parameters.Add("@P_Street", street);
            Parameters.Add("@P_HouseNumber", hn);
            return dbMan.ExecuteNonQuery(storedProcedurename, Parameters);
        }
        public int InsertPublisherPhoneNumber(int pid, string code, string phone)
        {
            string storedProcedurename = StoredProcedures.InsertPublisherPhoneNumber;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@P_ID", pid);
            Parameters.Add("@countrycode", code);
            Parameters.Add("@PhoneNumber", phone);
            
            return dbMan.ExecuteNonQuery(storedProcedurename, Parameters);
        }
        public DataTable Dgetusernameisbn()
        {
            string StoredProcedureName = StoredProcedures.Dgetusername_isbn;
            return dbMan.ExecuteReader(StoredProcedureName, null);
        }
        public DataTable Sgetusernameisbn()
        {
            string StoredProcedureName = StoredProcedures.Sgetusername_isbn;
            return dbMan.ExecuteReader(StoredProcedureName, null);
        }
        public DataTable Lgetusernameisbn()
        {
            string StoredProcedureName = StoredProcedures.Lgetusername_isbn;
            return dbMan.ExecuteReader(StoredProcedureName, null);
        }
        public DataTable Ogetusernameisbn()
        {
            string StoredProcedureName = StoredProcedures.Ogetusername_isbn;
            return dbMan.ExecuteReader(StoredProcedureName, null);
        }
        public int SupdateBookcount(int nc, string uname, string ispn)
        {
            string storedProcedurename = StoredProcedures.Supdatebookcount;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@new", nc);
            Parameters.Add("@ISBN", ispn);
            Parameters.Add("@username", uname);
            return dbMan.ExecuteNonQuery(storedProcedurename, Parameters);
        }
        public int LupdateBookcount(int nc, string uname, string ispn)
        {
            string storedProcedurename = StoredProcedures.Lupdatebookcount;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@new", nc);
            Parameters.Add("@ISBN", ispn);
            Parameters.Add("@username", uname);
            return dbMan.ExecuteNonQuery(storedProcedurename, Parameters);
        }
        public int DupdateBookcount(int nc, string uname, string ispn)
        {
            string storedProcedurename = StoredProcedures.Dupdatebookcount;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@new", nc);
            Parameters.Add("@ISBN", ispn);
            Parameters.Add("@username", uname);
            return dbMan.ExecuteNonQuery(storedProcedurename, Parameters);
        }

        public int OupdateBookcount(int nc, string uname, string ispn)
        {
            string storedProcedurename = StoredProcedures.Oupdatebookcount;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@new", nc);
            Parameters.Add("@ISBN", ispn);
            Parameters.Add("@username", uname);
            return dbMan.ExecuteNonQuery(storedProcedurename, Parameters);
        }
        public DataTable SelectPublishername()
        {
            string StoredProcedureName = StoredProcedures.GetPublisherName;
            return dbMan.ExecuteReader(StoredProcedureName, null);
        }
        public DataTable SelectPublisherAddress()
        {
            string StoredProcedureName = StoredProcedures.GetPublisherAddress;
           
            return dbMan.ExecuteReader(StoredProcedureName,null);
        }

        public DataTable SelectPublisherPhone()
        {
            string StoredProcedureName = StoredProcedures.GetPublisherPhone;
            
            return dbMan.ExecuteReader(StoredProcedureName, null);
        }
        public DataTable SelectAuthor()
        {
            string StoredProcedureName = StoredProcedures.Getauthor;
           
            return dbMan.ExecuteReader(StoredProcedureName,null);
        }
        
        public int Updatebooktolend(int P_ID, string uname, string ispn, int Aid)
        {
            string storedProcedurename = StoredProcedures.Updatebooktolend;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@ISBN", ispn);
            Parameters.Add("@username", uname);
            Parameters.Add("@A_ID", Aid);
            Parameters.Add("@P_ID", P_ID);
            return dbMan.ExecuteNonQuery(storedProcedurename, Parameters);
        }
        public int Updatebooktodonate(int P_ID, string uname, string ispn, int Aid)
        {
            string storedProcedurename = StoredProcedures.Updatebooktodonate;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@ISBN", ispn);
            Parameters.Add("@username", uname);
            Parameters.Add("@A_ID", Aid);
            Parameters.Add("@P_ID", P_ID);


            return dbMan.ExecuteNonQuery(storedProcedurename, Parameters);
        }
        public int Updatebooktosell(int P_ID, string uname, string ispn, int Aid)
        {
            string storedProcedurename = StoredProcedures.Updatebooktosell;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@ISBN", ispn);
            Parameters.Add("@username", uname);
            Parameters.Add("@A_ID", Aid);
            Parameters.Add("@P_ID", P_ID);


            return dbMan.ExecuteNonQuery(storedProcedurename, Parameters);
        }

/// ////////////////////////////////////////////////////////////////////////////////////////////////

        public DataTable sellbooksofuser(string username)
        {
            string StoredProcedureName = StoredProcedures.sellbooksofuser;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@username", username); 
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }
        public DataTable lendbooksofuser(string username)
        {
            string StoredProcedureName = StoredProcedures.lendbooksofuser;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@username", username);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }
        public DataTable donatebooksofuser(string username)
        {
            string StoredProcedureName = StoredProcedures.donatebooksofuser;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@username", username);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }
        public string buyerbookformuser(string username,string ISBN)
        {
            string StoredProcedureName = StoredProcedures.buyerbookformuser;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@username", username);
            Parameters.Add("@ISBN", ISBN);
            return (string)dbMan.ExecuteScalar(StoredProcedureName, Parameters);
        }
        public DataTable borrowbookformuser(string username,string ISBN)
        {
            string StoredProcedureName = StoredProcedures.borrowbookformuser;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@username", username);
            Parameters.Add("@ISBN", ISBN);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }
        public DataTable takerbookformuser(string username,string ISBN)
        {
            string StoredProcedureName = StoredProcedures.takerbookformuser;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@username", username);
            Parameters.Add("@ISBN", ISBN);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }
        public string ISBNdonatebooksofuser(string username,string title)
        {
            string StoredProcedureName = StoredProcedures.ISBNdonatebooksofuser;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@username", username);
            Parameters.Add("@title", title);
            return (string)dbMan.ExecuteScalar(StoredProcedureName, Parameters);
        }
        public string ISBNlendbooksofuser(string username, string title)
        {
            string StoredProcedureName = StoredProcedures.ISBNlendbooksofuser;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@username", username);
            Parameters.Add("@title", title);
            return (string)dbMan.ExecuteScalar(StoredProcedureName, Parameters);
        }
        public string ISBNsellbooksofuser(string username, string title)
        {
            string StoredProcedureName = StoredProcedures.ISBNsellbooksofuser;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@username", username);
            Parameters.Add("@title", title);
            return (string)dbMan.ExecuteScalar(StoredProcedureName, Parameters);
        }
        public int deletebookfromtakefree(string username,string ISBN)
        {
            string StoredProcedureName = StoredProcedures.deletebookfromtakefree;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@username", username);
            Parameters.Add("@ISBN", ISBN);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        public int deletebookfromborrow(string username, string ISBN)
        {
            string StoredProcedureName = StoredProcedures.deletebookfromborrow;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@username", username);
            Parameters.Add("@ISBN", ISBN);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        public int deletebookfrombuy(string username, string ISBN)
        {
            string StoredProcedureName = StoredProcedures.deletebookfrombuy;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@username", username);
            Parameters.Add("@ISBN", ISBN);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        public string isbndonate(string title)
        {
            string StoredProcedureName = StoredProcedures.isbndonate;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@title", title);
            return (string)dbMan.ExecuteScalar(StoredProcedureName, Parameters);
        }

        public string isbnlend(string title)
        {
            string StoredProcedureName = StoredProcedures.isbnlend;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@title", title);
            return (string)dbMan.ExecuteScalar(StoredProcedureName, Parameters);
        }

        public string isbnsell(string title)
        {
            string StoredProcedureName = StoredProcedures.isbnsell;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@title", title);
            return (string)dbMan.ExecuteScalar(StoredProcedureName, Parameters);
        }
        public DataTable SelectSell()
        {
            string StoredProcedureName = StoredProcedures.SellForm;
            return dbMan.ExecuteReader(StoredProcedureName, null);

        }

        public DataTable SelectFree()
        {
            string StoredProcedureName = StoredProcedures.FreeFrm;
            return dbMan.ExecuteReader(StoredProcedureName, null);

        }
        public DataTable SelectLend()
        {
            string StoredProcedureName = StoredProcedures.LendFrm;
            return dbMan.ExecuteReader(StoredProcedureName, null);

        }

        public DataTable AllSell(string username, string ISBN)
        {

            string StoredProcedureName = StoredProcedures.SellAll;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@ISBNN", ISBN);
            Parameters.Add("@user", username);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }

        public DataTable AllLend(string username, string ISBN)
        {

            string StoredProcedureName = StoredProcedures.LendAll;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@ISBNN", ISBN);
            Parameters.Add("@user", username);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }

        public DataTable AllDonate(string username, string ISBN)
        {

            string StoredProcedureName = StoredProcedures.DonateAll;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@ISBNN", ISBN);
            Parameters.Add("@user", username);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }

        public DataTable Author(int AuthorID)
        {
            string StoredProcedureName = StoredProcedures.SelectAuthor;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@ID", AuthorID);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }

        public DataTable AuthorDate(int AuthorID)
        {
            string StoredProcedureName = StoredProcedures.SelectAuthorDate;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@ID", AuthorID);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }
        public DataTable Publisher(int PublisherID)
        {
            string StoredProcedureName = StoredProcedures.SelectPublisher;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@ID", PublisherID);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }
        public DataTable PublisherAdress(int PublisherID)
        {
            string StoredProcedureName = StoredProcedures.SelectPublisherAdresses;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@ID", PublisherID);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }

        public DataTable PublisherPhone(int PublisherID)
        {
            string StoredProcedureName = StoredProcedures.SelectPublisherPhone;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@ID", PublisherID);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }

        public DataTable CompanyCity()
        {
            string StoredProcedureName = StoredProcedures.SelectCities;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            return dbMan.ExecuteReader(StoredProcedureName, null);
        }

        public DataTable SelectCompanyCity(string city)
        {
            string StoredProcedureName = StoredProcedures.SelectCompanyCities;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@City", city);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }

        public DataTable SelectBuyCountD(string ISBN, string username)
        {
            string StoredProcedureName = StoredProcedures.SellCountD;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@ISN", ISBN);
            Parameters.Add("@user", username);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }

        public DataTable SelectLendCountD(string ISBN, string username)
        {
            string StoredProcedureName = StoredProcedures.LendCountD;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@ISN", ISBN);
            Parameters.Add("@user", username);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }

        public DataTable SelectDonateCountD(string ISBN, string username)
        {
            string StoredProcedureName = StoredProcedures.DonateCountD;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@ISN", ISBN);
            Parameters.Add("@user", username);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }

        public int InsertBuyNoShipping(string ISBN, string userSeller, string UserBuier, int BookCount)
        {
            string StoredProcedureName = StoredProcedures.InsertBuyWithoutShipping;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@ISBN", ISBN);
            Parameters.Add("@userSeller", userSeller);
            Parameters.Add("@userBuier", UserBuier);
            Parameters.Add("@Bookcount", BookCount);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        public int InsertBuyShipping(string ISBN, string userSeller, string UserBuier, string ID, int price, int period, int BookCount)
        {
            string StoredProcedureName = StoredProcedures.InsertBuyShipping;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@ISBN", ISBN);
            Parameters.Add("@userSeller", userSeller);
            Parameters.Add("@userBuier", UserBuier);
            Parameters.Add("@ID", ID);
            Parameters.Add("@SH_price", price);
            Parameters.Add("@SH_period", period);
            Parameters.Add("@Bookcount", BookCount);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        public int InsertBorrowShipping(string ISBN, string userLender, string UserBorrower, string ID, int price, int period, int BookCount)
        {
            string StoredProcedureName = StoredProcedures.InsertBorrowShipping;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@ISBN", ISBN);
            Parameters.Add("@userLender", userLender);
            Parameters.Add("@userBorrower", UserBorrower);
            Parameters.Add("@ID", ID);
            Parameters.Add("@SH_price", price);
            Parameters.Add("@SH_period", period);
            Parameters.Add("@Bookcount", BookCount);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        public int InsertBorrowNoShipping(string ISBN, string userLender, string UserBorrower, int BookCount)
        {
            string StoredProcedureName = StoredProcedures.InsertBorrowWithoutShippping;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@ISBN", ISBN);
            Parameters.Add("@userLender", userLender);
            Parameters.Add("@userBorrower", UserBorrower);
            Parameters.Add("@Bookcount", BookCount);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        public int InsertTakeShipping(string ISBN, string userVolunteer, string UserTaker, string ID, int price, int period, int BookCount)
        {
            string StoredProcedureName = StoredProcedures.InsertTakeShippping;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@ISBN", ISBN);
            Parameters.Add("@userVolunteer", userVolunteer);
            Parameters.Add("@userTaker", UserTaker);
            Parameters.Add("@ID", ID);
            Parameters.Add("@SH_price", price);
            Parameters.Add("@SH_period", period);
            Parameters.Add("@Bookcount", BookCount);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        public int InsertTakeNoShipping(string ISBN, string userVolunteer, string UserTaker, int BookCount)
        {
            string StoredProcedureName = StoredProcedures.InsertTakeWithoutShippping;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@ISBN", ISBN);
            Parameters.Add("@userVolunteer", userVolunteer);
            Parameters.Add("@userTaker", UserTaker);
            Parameters.Add("@Bookcount", BookCount);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        public int decCountSell(int Count, string username, string ISBN)
        {
            string StoredProcedureName = StoredProcedures.DecrementCountSell;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@new", Count);
            Parameters.Add("@username", username);
            Parameters.Add("@ISBN", ISBN);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        public int decCountLend(int Count, string username, string ISBN)
        {
            string StoredProcedureName = StoredProcedures.DecrementCountLend;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@new", Count);
            Parameters.Add("@username", username);
            Parameters.Add("@ISBN", ISBN);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        public int decCountDonate(int Count, string username, string ISBN)
        {
            string StoredProcedureName = StoredProcedures.DecrementCountDonate;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@new", Count);
            Parameters.Add("@username", username);
            Parameters.Add("@ISBN", ISBN);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        public DataTable SelectUserInfoD(string username)
        {
            string StoredProcedureName = StoredProcedures.SelectUserInfo;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@user", username);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }

        public DataTable AdressesAllD(int ID)
        {
            string StoredProcedureName = StoredProcedures.SelactDComAllAdress;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@ID", ID);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }

        public DataTable PhoneAllD(int ID)
        {
            string StoredProcedureName = StoredProcedures.SelactDComAllPhhone;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@ID", ID);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }

        public DataTable OrdersD()
        {
            string StoredProcedureName = StoredProcedures.SelectOrdersD;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            return dbMan.ExecuteReader(StoredProcedureName, null);
        }
        //public int numofrowsofbuybooks()
        //{
        //    string StoredProcedureName = StoredProcedures.numofrowsofbuybooks;
        //    Dictionary<string, object> Parameters = new Dictionary<string, object>();
        //    return (int)dbMan.ExecuteScalar(StoredProcedureName, Parameters);
        //}
        //public int numofrowsofborrowbooks()
        //{
        //    string StoredProcedureName = StoredProcedures.numofrowsofborrowbooks;
        //    Dictionary<string, object> Parameters = new Dictionary<string, object>();
        //    return (int)dbMan.ExecuteScalar(StoredProcedureName, Parameters);
        //}
        //public int numofrowsoftakebooks()
        //{
        //    string StoredProcedureName = StoredProcedures.numofrowsoftakebooks;
        //    Dictionary<string, object> Parameters = new Dictionary<string, object>();
        //    return (int)dbMan.ExecuteScalar(StoredProcedureName, Parameters);

        //}
        public DataTable Select_Seminars()
        {
            string StoredProcedureName = StoredProcedures.Select_Seminars;
            return dbMan.ExecuteReader(StoredProcedureName, null);
        }
        public int AddaSeminar(string topic, string S_date, string Details, string S_State, string S_City, string S_Distinct, string S_Street, string S_HouseNumber)
        {
            string StoredProcedureName = StoredProcedures.AddaSeminar;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@topic", topic);
            Parameters.Add("@S_date", S_date);
            Parameters.Add("@Details", Details);
            Parameters.Add("@S_State", S_State);
            Parameters.Add("@S_City", S_City);
            Parameters.Add("@S_Distinct", S_Distinct);
            Parameters.Add("@S_Street", S_Street);
            Parameters.Add("@S_HouseNumber", S_HouseNumber);

            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        public int AddanAdmin(string fname, string lname, string username, string password, string email, string state, string city, string district, string street, int housnumber, string postalnum, string countrycode, string phonenumber)
        {
            string StoredProcedureName = StoredProcedures.AddanAdmin;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Fname", fname);
            Parameters.Add("@Lname", lname);
            Parameters.Add("@username", username);
            Parameters.Add("@PW", password);
            Parameters.Add("@email", email);
            Parameters.Add("@stat", state);
            Parameters.Add("@city", city);
            Parameters.Add("@district", district);
            Parameters.Add("@street", street);
            Parameters.Add("@HouseNumber", housnumber);
            Parameters.Add("@postalNumber", postalnum);
            Parameters.Add("@countrycode", countrycode);
            Parameters.Add("@PhoneNumber", phonenumber);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        public int SetNewAdminPW(string username, string oldpassword, string newpassword)
        {
            string StoredProcedureName = StoredProcedures.SetNewAdminPW;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();

            Parameters.Add("@username", username);
            Parameters.Add("@PWold", oldpassword);
            Parameters.Add("@PWnew", newpassword);


            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        public int SetUserPW(string username, string oldpassword, string newpassword)
        {
            string StoredProcedureName = StoredProcedures.SetUserPW;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();

            Parameters.Add("@username", username);
            Parameters.Add("@PWold", oldpassword);
            Parameters.Add("@PWnew", newpassword);


            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        public int DeleteaSeminar(string topic, string S_date)
        {
            string StoredProcedureName = StoredProcedures.DeleteaSeminar;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@topic", topic);
            Parameters.Add("@S_date", S_date);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        public DataTable SeminarTopic()
        {
            string StoredProcedureName = StoredProcedures.SelectSeminarTopic;
            return dbMan.ExecuteReader(StoredProcedureName, null);
        }
        public DataTable SeminarDate(string topic)
        {
            string StoredProcedureName = StoredProcedures.Select_Seminars2;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@topic", topic);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }
        public DataTable SelectCompanyId(string email)
        {
            string StoredProcedureName = StoredProcedures.SelectCompanyID;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Email", email);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }
        public int InsertCompany(string CompanyName, string Adminusername, string email)
        {
            string storedProcedurename = StoredProcedures.AddCompany;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Company_Name", CompanyName);
            Parameters.Add("@Admin_username", Adminusername);
            Parameters.Add("@Email", email);
            return dbMan.ExecuteNonQuery(storedProcedurename, Parameters);
        }
        public int InsertCompanyAddress(int Com_ID, string SH_State, string SH_City, string SH_Distinct, string SH_Street, string SH_HouseNumber)
        {
            string storedProcedurename = StoredProcedures.AddCompanyAddress;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Com_ID", Com_ID);
            Parameters.Add("@SH_State", SH_State);
            Parameters.Add("@SH_City", SH_City);
            Parameters.Add("@SH_Distinct", SH_Distinct);
            Parameters.Add("@SH_Street", SH_Street);
            Parameters.Add("@SH_HouseNumber", SH_HouseNumber);
            return dbMan.ExecuteNonQuery(storedProcedurename, Parameters);
        }
        public int InsertCompanyPhone(int Com_ID, string countrycode, string PhoneNumber)
        {
            string storedProcedurename = StoredProcedures.AddCompanyPhone;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Com_ID", Com_ID);
            Parameters.Add("@countrycode", countrycode);
            Parameters.Add("@PhoneNumber", PhoneNumber);
            return dbMan.ExecuteNonQuery(storedProcedurename, Parameters);
        }
        public int InsertCompanyDest(int Com_ID, string Destination, float SH_Price, int SH_Period)
        {
            string storedProcedurename = StoredProcedures.AddCompanyDestination;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Com_ID", Com_ID);
            Parameters.Add("@Destination", Destination);
            Parameters.Add("@SH_Price", SH_Price);
            Parameters.Add("@SH_Period", SH_Period);
            return dbMan.ExecuteNonQuery(storedProcedurename, Parameters);
        }
        public DataTable Select_Company()
        {
            string StoredProcedureName = StoredProcedures.Select_Company;
            return dbMan.ExecuteReader(StoredProcedureName, null);
        }
        public DataTable SelectShippingCompany()
        {
            string StoredProcedureName = StoredProcedures.SelectShippingCompany;
            return dbMan.ExecuteReader(StoredProcedureName, null);
        }

        public int DeleteaCompany(string name)
        {
            string StoredProcedureName = StoredProcedures.Delete_company;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Company_Name", name);

            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        public DataTable SelectCompanyAddress(int Com_ID)
        {
            string StoredProcedureName = StoredProcedures.SelectCompanyAddress;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Com_ID", Com_ID);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }
        public DataTable SelectCompanyPhonenumbers(int Com_ID)
        {
            string StoredProcedureName = StoredProcedures.SelectCompanyPhonenumbers;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Com_ID", Com_ID);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }
        public DataTable SelectCompanyDestinations(int Com_ID)
        {
            string StoredProcedureName = StoredProcedures.SelectCompanyDestinations;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Com_ID", Com_ID);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);

        }
        public int DeleteCompanyAddress(int Com_ID)
        {
            string StoredProcedureName = StoredProcedures.DeleteCompanyAddress;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Com_ID", Com_ID);

            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        public int DeleteCompanyPhonenumbers(int Com_ID)
        {
            string StoredProcedureName = StoredProcedures.DeleteCompanyPhonenumbers;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Com_ID", Com_ID);

            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        public int DeleteCompanyDestination(int Com_ID)
        {
            string StoredProcedureName = StoredProcedures.DeleteCompanyDestination;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Com_ID", Com_ID);

            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        public DataTable SelectAdmins()
        {
            string StoredProcedureName = StoredProcedures.SelectAdmins;
            return dbMan.ExecuteReader(StoredProcedureName, null);
        }
    }
}
