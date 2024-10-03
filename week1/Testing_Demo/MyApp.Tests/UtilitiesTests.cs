namespace MyApp.Tests;

using System.Drawing;
using MyApp.APP.Utils;

public class UtilitiesTests
{
    [Fact]
    public void Util_IsEven_Returns_Bool_Correctly()
    {
        //AAA of testing

        //Arrange
        int number = 458;
        //Act
        bool result = Utilities.IsEven(number);
        //Assert
        Assert.True(result);
    }

    [Theory]
    [InlineData(1,false)]
    [InlineData(2,true)]
    [InlineData(456,true)]
    [InlineData(789,false)]
    [InlineData(999,false)]
    [InlineData(654,true)]
    [InlineData(3,false)]
    public void Util_IsEven_Returns_Correctly_ForAll(int number, bool expected)
    {
        //Arrange

        //Act
        bool result = Utilities.IsEven(number);
        //Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void Util_Add_Name_Works()
    {
        //Arrange
        List<string> nameList = [
            "Kung",
            "Vlada"
        ];
        
        //Act
        string name = "Joey";
        Utilities.AddName(name, nameList);

        //Assert
        Assert.Contains(name, nameList);
    }

    [Fact]
    public void Util_List_Name_Works()
    {
        //Arrange
        List<string> nameList = [
            "Kung",
            "Vlada"
        ];

        StringWriter sw = new();
        
        //Act
        Utilities.ListNamesDI(nameList, sw);

        //string[] nameArr = sw.ToString().Split("\r\n");

        //Assert
        Assert.Contains("Kung", sw.ToString());
    }

}