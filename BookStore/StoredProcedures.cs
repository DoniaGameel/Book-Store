using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BookStore
{
    public class StoredProcedures
    {
        public static string RetrieveProject = "selectProjectsofDeptLoc";
        public static string SelectAllEmployees = "getAllEmps";
        public static string InsertProject = "insertProject";
        public static string SelectDepartmentNum = "selectDepartmentNum";
        public static string SelectDepartmentLocation = "selectDepartmentLocation";
        //ASMAA
        public static string getusernames = "getusernames";
        public static string getusernameadmin = "getusernameadmin";
        public static string passwordofusername = "passwordofusername";
        public static string passwordofusernameadmin = "passwordofusernameadmin";
        public static string signupform = "signupform";
        public static string takenbooksforspecificuser = "takenbooksforspecificuser";
        public static string buyingbooksforspecificuser = "buyingbooksforspecificuser";
        public static string borrowingbooksforspecificuser = "borrowingbooksforspecificuser";
        public static string selectcountofbuyingbooks = "selectcountofbuyingbooks";
        public static string deletebook = "deletebook";
        public static string updatecountofbooks = "updatecountofbooks";
        public static string selectcountofborrowbooks = "selectcountofborrowbooks";
        public static string updatecountofborrowbooks = "updatecountofborrowbooks";
        public static string deleteborrowbook = "deleteborrowbook";
        public static string selectcountoftakebooks = "selectcountoftakebooks";
        public static string updatecountoftakebooks = "updatecountoftakebooks";
        public static string deletetakebook = "deletetakebook";
        public static string sellbooksofuser = "sellbooksofuser";
        public static string lendbooksofuser = "lendbooksofuser";
        public static string donatebooksofuser = "donatebooksofuser";
        public static string buyerbookformuser = "buyerbookformuser";
        public static string borrowbookformuser = "borrowbookformuser";
        public static string takerbookformuser = "takerbookformuser";
        public static string ISBNdonatebooksofuser = "ISBNdonatebooksofuser";
        public static string ISBNlendbooksofuser = "ISBNlendbooksofuser";
        public static string ISBNsellbooksofuser = "ISBNsellbooksofuser";
        public static string numofrowsofbuybooks = "numofrowsofbuybooks";
        public static string numofrowsofborrowbooks = "numofrowsofborrowbooks";
        public static string numofrowsoftakebooks = "numofrowsoftakebooks";
        public static string deletebookfromtakefree = "deletebookfromtakefree";
        public static string deletebookfromborrow = "deletebookfromborrow";
        public static string deletebookfrombuy = "deletebookfrombuy";
        public static string isbndonate = "isbndonate";
        public static string isbnlend = "isbnlend";
        public static string isbnsell = "isbnsell";
        public static string selectcountbookstosell = "selectcountbookstosell";
        public static string selectcountbookstolend = "selectcountbookstolend";
        public static string selectcountbookstodonate = "selectcountbookstodonate";
        public static string selectcountofbuy = "selectcountofbuy";
        public static string selectcountofborrow = "selectcountofborrow";
        public static string selectcountoftake = "selectcountoftake";
        public static string updatecountbookstosell = "updatecountbookstosell";
        public static string updatecountbookstolend = "updatecountbookstolend";
        public static string updatecountbookstodonate = "updatecountbookstodonate";
        public static string deletebookstosell = "deletebookstosell";
        public static string deletebookstolend = "deletebookstolend";
        public static string deletebookstodonate = "deletebookstodonate";


        //DONIA
        public static string SellForm = "SelectToSELL";
        public static string FreeFrm = "SelectToDonate";
        public static string LendFrm = "SelectToLEND";
        public static string SellAll = "SellAll";
        public static string LendAll = "LendAll";
        public static string DonateAll = "DonateAll";
        public static string SelectAuthor = "SelectAuthor";
        public static string SelectPublisher = "SelectPublisher";
        public static string SelectAuthorDate = "SelectAuthorDate";
        public static string SelectPublisherAdresses = "SelectPublisherAdresses";
        public static string SelectPublisherPhone = "SelectPublisherPhone";
        public static string SelectCities = "SelectCities";
        public static string SelectCompanyCities = "SelectCompanyCities";
        public static string SellCountD = "SellCountD";
        public static string LendCountD = "LendCountD";
        public static string DonateCountD = "DonateCountD";
        public static string InsertBuyWithoutShipping = "InsertBuyWithoutShipping";
        public static string InsertBuyShipping = "InsertBuyShipping";
        public static string InsertBorrowShipping = "InsertBorrowShipping";
        public static string InsertBorrowWithoutShippping = "InsertBorrowWithoutShippping";
        public static string InsertTakeWithoutShippping = "InsertTakeWithoutShippping";
        public static string InsertTakeShippping = "InsertTakeShippping";
        public static string DecrementCountDonate = "DecrementCountDonate";
        public static string DecrementCountLend = "DecrementCountLend";
        public static string DecrementCountSell = "DecrementCountSell";

        public static string SelectUserInfo = "SelectUserInfo";
        public static string SelactDComAllAdress = "SelactDComAllAdress";
        public static string SelactDComAllPhhone = "SelactDComAllPhhone";
        public static string SelectOrdersD = "SelectOrdersD";
        
        //SALMA
        public static string InsertBookToSell = "InsertBooksToSell";
        public static string InsertBookToLend = "InsertBookrToLend";
        public static string InsertBookToDonate = "InsertBooksToDonate";
        public static string InsertAuthor = "InsertAuthor";
        public static string InsertPublisher = "InsertPublisher";
        public static string Updatebooktolend = "updatebooktolend";
        public static string Updatebooktosell = "updatebooktosell";
        public static string Updatebooktodonate = "updatebooktodonate";
        public static string InsertPublisherAddress = "Insertpublisheraddress";
        public static string InsertPublisherPhoneNumber = "Insertpublisherphonenumber";
        public static string SelectPublisherID = "selectpublisherid";
        public static string SelectAuthorID = "Select_Authorid";
        public static string GetPublisherEmail = "getpublisheremail";
        public static string GetPublisherName = "getpublishername";
        public static string GetPublisherAddress = "getpublisheraddress";
        public static string GetPublisherPhone = "getpublisherphone";

        public static string Dgetusername_isbn  = "dgetusername_isbn";
        public static string Sgetusername_isbn = "sgetusername_isbn";
        public static string Lgetusername_isbn = "lgetusername_isbn";
        public static string Ogetusername_isbn = "ogetusername_isbn";

        public static string Oupdatebookcount = "oupdatebookcount";
        public static string Supdatebookcount = "supdatebookcount";
        public static string Lupdatebookcount = "lupdatebookcount";
        public static string Dupdatebookcount = "dupdatebookcount";
        public static string InsertBookToorder = "InsertBookToOrder";
        public static string Getauthor = "getauthor";


        //Admins
        public static string AddaSeminar = "AddaSeminar";//
        public static string AddanAdmin = "AddanAdmin";//
        public static string SetNewAdminPW = "SetNewAdminPW";//
        public static string SetUserPW = "SetNewUserPW";//
        public static string Select_Seminars = "Select_Seminars";//
        public static string SelectCompanyID = "SelectCompanyID";//
        public static string AddCompany = "AddCompany";//
        public static string AddCompanyAddress = "AddCompanyAddress";//
        public static string AddCompanyPhone = "AddCompanyPhone";//
        public static string AddCompanyDestination = "AddCompanyDestination";//
        public static string DeleteaSeminar = "DeleteaSeminar";//
        public static string SelectSeminarTopic = "SelectSeminarTopic";//
        public static string SelectSeminarDate = "SelectSeminarDate";//
        public static string Select_Seminars2 = "Select_Seminars2";//BAD
        public static string Select_Company = "Select_Company";
        public static string Delete_company = "Delete_company";
        public static string SelectShippingCompany = "SelectShippingCompany";
        public static string SelectCompanyAddress = "SelectCompanyAddress";
        public static string SelectCompanyPhonenumbers = "SelectCompanyPhonenumbers";
        public static string SelectCompanyDestinations = "SelectCompanyDestinations";
        public static string DeleteCompanyAddress = "DeleteCompanyAddress";
        public static string DeleteCompanyPhonenumbers = "DeleteCompanyPhonenumbers";
        public static string DeleteCompanyDestination = "DeleteCompanyDestination";
        public static string SelectAdmins = "SelectAdmins";


    }
}
