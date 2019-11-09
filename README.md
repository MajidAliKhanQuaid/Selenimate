# Selenimate [Class Library]

Use UXunit with Selenium web driver library to enhance the automated test driven development

Packages required

``` xml
<ItemGroup>
    <PackageReference Include="Selenium.Chrome.WebDriver" Version="77.0.0" />
    <PackageReference Include="Selenium.Firefox.WebDriver" Version="0.26.0" />
    <PackageReference Include="Selenium.Support" Version="3.141.0" />
    <PackageReference Include="Selenium.WebDriver" Version="3.141.0" />
    <PackageReference Include="Selenium.WebDriver.MicrosoftDriver" Version="17.17134.0" />
    <PackageReference Include="xunit" Version="2.4.1" />
    <PackageReference Include="xunit.assert" Version="2.4.1" />
    <PackageReference Include="xunit.core" Version="2.4.1" />
    <PackageReference Include="xunit.runner.visualstudio" Version="2.4.1">
      <PrivateAssets>all</PrivateAssets>
      <IncludeAssets>runtime; build; native; contentfiles; analyzers</IncludeAssets>
    </PackageReference>
</ItemGroup>
```

To test the login functionality, we need to have the some identifier to the fields i.e. email, password.
then the test can go as

``` cs
[Fact]
public void TestWithFirefoxDriver()
{
    using (var driver = new FirefoxDriver(Environment.CurrentDirectory))
    {
        driver.Navigate().GoToUrl(Website);
        //
        var email = driver.FindElement(By.Id("Email"));
        email.SendKeys(Email);
        //
        var password = driver.FindElement(By.Id("Password"));
        password.SendKeys(Password);
        //
        var submitBtn = driver.FindElement(By.ClassName("login-button"));
        submitBtn.Click();
        
        // the item `PriceDDL` is found on the page; we consider that it was a valid login
        var foundDropDown = new WebDriverWait(driver, TimeSpan.FromSeconds(10)).Until(x => { return x.FindElement(By.Id("PriceDDL")) != null; });
        Assert.True(foundDropDown);
    }
}
```

To run the test cases, execute

``` ps
dotnet test
```
