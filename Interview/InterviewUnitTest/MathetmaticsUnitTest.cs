namespace InterviewUnitTest;

using Microsoft.AspNetCore.Mvc;
using NUnit;
using Newtonsoft.Json;

public class MathetmaticsUnitTest
{
    [Test]
    public void Is_Summary_Result_True()
    {  //Arrange
        var summary = new Interview.Controllers.MathematicalController();
        var maths = new Interview.MathDTO();
        maths.numberOne = 10;
        maths.numberTwo = 21;
        var checkResult = maths.numberOne + maths.numberTwo;
        //Action
        var method = summary.Summary(maths) as JsonResult;
       var result = method.Value;
        //Assert
        Assert.That(result, Is.EqualTo(checkResult));
    }
    [Test]
    public void Is_Subtract_Result_True()
    {  //Arrange
        var subtract = new Interview.Controllers.MathematicalController();
        var maths = new Interview.MathDTO();
        maths.numberOne = 25;
        maths.numberTwo = 12;
        var checkResult = maths.numberOne - maths.numberTwo;

        //Action
        var method = subtract.Subtract(maths) as JsonResult;
        var result = method.Value;
        //Assert
        Assert.That(result, Is.EqualTo(checkResult));
    }
    [Test]
    public void Is_Multiply_Result_True()
    {  //Arrange
        var multiply = new Interview.Controllers.MathematicalController();
        var maths = new Interview.MathDTO();
        maths.numberOne = 5;
        maths.numberTwo = 25;
        var checkResult = maths.numberOne * maths.numberTwo;

        //Action
        var method = multiply.Multiply(maths) as JsonResult;
        var result = method.Value;
        //Assert
        Assert.That(result, Is.EqualTo(checkResult));
    }
    [Test]
    public void Is_Divide_Result_True()
    {  //Arrange
        var divide = new Interview.Controllers.MathematicalController();
        var maths = new Interview.MathDTO();
        maths.numberOne = 45;
        maths.numberTwo = 9;
        var checkResult = maths.numberOne / maths.numberTwo;

        //Action
        var method = divide.Divide(maths) as JsonResult;
        var result = method.Value;
        //Assert
        Assert.That(result, Is.EqualTo(checkResult));
    }


}
