namespace Task_24_04_2018
{
    class XPathLocators
    {
        public string loginField = "//*[@id=\"quick_email\"]";
        public string passwordField = "//*[@id=\"quick_pass\"]";
        public string loginButton = "//*[@id=\"quick_login_button\"]";
        public string messageButton = "//*[@id=\"l_msg\"]";
        public string firstDialogue = "//*[@id=\"im_dialogs\"]/*[1]";
        public string lastMessageInDialog = "(//*[@class=\"im-mess--text wall_module _im_log_body\"])[last()]";
        public string topMenu = "(//*[@class=\"top_profile_arrow\"])";
        public string logoutButton = "(//*[@id=\"top_logout_link\"])";

    }
}
