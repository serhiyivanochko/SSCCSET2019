using SSCCSET2019.Pages;

namespace SSCCSET2019.Logic
{
    class MainPageLogic
    {
        MainPage mainPage = new MainPage(); //Where is better to place 
        //Header of main page
        public void TestHeaderMainPage()
        {
            mainPage.buttonClick();
            mainPage.Link_theme();
            mainPage.Link_firstRecord();
            mainPage.Link_createPage();
            mainPage.Link_setMainPage();
            mainPage.Link_lookSite();
            mainPage.Link_vidgets();
            mainPage.Link_menu();
            mainPage.Link_turnOffComments();
            mainPage.Link_learnMore();
            mainPage.Button_header_close();

        }
        //Quick Drafts 
        public void TestQuickDraft()
        {
            mainPage.writeTo_headline("Lorem ipsum");  //How do it properly 
            mainPage.write_Content("Some story");
            mainPage.Button_save();
            mainPage.Button_hide();
        }
        //News
        public void TestNews()
        {

            mainPage.Button_close();
            mainPage.Button_edit();
            mainPage.Town_input("Lorem");
            mainPage.Button_send();
            mainPage.Button_cancel();
            mainPage.Link_1();
            mainPage.Link_2();
            mainPage.Link_3();
            mainPage.Link_4();
            mainPage.Link_meetings();
            mainPage.Link_wordcamp();
            mainPage.Link_news();

        }
    }
}

