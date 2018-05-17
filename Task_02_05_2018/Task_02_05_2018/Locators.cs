namespace Task_02_05_2018
{
    class Locators
    {
        public string briefInformationAboutCar = "//*[@class=\"listing-item-price\"]";
        public string allMarkButton = "//*[@class=\"js-brands-show-all\"]";
        public string marks = "//*[@class=\"brandsitem brandsitem--primary\"]";
        public string markNameTag = "span";
        public string models = "//*[@class=\"brandsitem brandsitem--primary\"]";
        public string modelNameTag = "span";
        public string numberОfСarsTag = "small";

        public string CreateXPathForCarMark(string carMark)
        {
            return "//*[@class=\"brandsitem brandsitem--primary\"]//*[contains(text(),\"" + carMark + "\")]";
        }

        public string CreateXPathForCarModel(string carModel)
        {
            return "//*[@class=\"brandsitem brandsitem--primary\"]//*[contains(text(),\"" + carModel + "\")]";
        }
    }
}
