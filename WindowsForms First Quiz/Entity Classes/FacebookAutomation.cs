using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsForms_First_Quiz.Custom_Exception_Classes;

namespace WindowsForms_First_Quiz.Entity_Classes
{    
    public class FacebookAutomation
    {
        private readonly IWebDriver webDriver;

        public FacebookAutomation(IWebDriver webDriver)
        {
            this.webDriver = webDriver;
        }
        
        public void Login(string username, string password)
        {
            // Navigate to Facebook
            webDriver.Url = "https://www.facebook.com/";

            // Find the username field (Facebook calls it "email") and enter value
            var input = webDriver.FindElement(By.Id("email"));
            input.SendKeys(username);

            // Find the password field and enter value
            input = webDriver.FindElement(By.Id("pass"));
            input.SendKeys(password);

            // Click on the login button

            try
            {
                ClickAndWaitForPageToLoad(webDriver, By.Name("login"));
            }
            catch (LoginNotSuccessfullException)
            {
                throw;
            }



            // At this point, Facebook will launch a post-login "wizard" that will 
            // keep asking unknown amount of questions (it thinks it's the first time 
            // you logged in using this computer). We'll just click on the "continue" 
            // button until they give up and redirect us to our "wall".
            try
            {
                while (webDriver.FindElement(By.Id("checkpointSubmitButton")) != null)
                {
                    // Clicking "continue" until we're done
                    ClickAndWaitForPageToLoad(webDriver, By.Id("checkpointSubmitButton"));
                }
            }            
            catch (LoginNotSuccessfullException)
            {                
                throw;
            }                        
            catch
            {
                // We will try to click on the next button until it's not there or we fail.
                // Facebook is unexpected as to what will happen, but this approach seems 
                // to be pretty reliable
            }
        }

        private void ClickAndWaitForPageToLoad(IWebDriver driver, By elementLocator, int timeout = 10)
        {
            try
            {
                var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeout));
                var elements = driver.FindElements(elementLocator);
                if (elements.Count == 0)
                {                 
                    throw new LoginNotSuccessfullException(
                        "No elements " + elementLocator + " ClickAndWaitForPageToLoad.");
                }
                var element = elements.FirstOrDefault(e => e.Displayed);
                element.Click();
                wait.Until(ExpectedConditions.StalenessOf(element));//bura gelir login ola bilmir privacy settinglere gedir.

                if (webDriver.Url.StartsWith(@"https://www.facebook.com/login/?privacy"))
                {
                    throw new LoginNotSuccessfullException("User did not have Facebook account.");
                }
            }
            catch (LoginNotSuccessfullException)
            {             
                throw;
            }
            catch (NoSuchElementException)
            {
                throw;
            }
            catch(InvalidOperationException)
            {
                throw;
            }
        }
    }

}
