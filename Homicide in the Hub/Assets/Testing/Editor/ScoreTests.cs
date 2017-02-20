using UnityEngine;
using UnityEditor;
using NUnit.Framework;

public class ScoreTests {

	[Test]
	public void ConvertTimeTest()
	{
        //Arrange
        ShowScore scoreclass = new ShowScore();

        //Act
        //calcualte the time
        string converted_time = scoreclass.convert_time(90);


        //Assert
        //The object has a new name
        Assert.AreEqual("1:30",converted_time);
	}

	[Test]
	public void Calculate_Test()
	{
		//Arrange
		ShowScore scoreclass1 = new ShowScore();

		//Act
		double calculated_score = scoreclass1.caluclate_score(90,2);

		//Assert
		Assert.AreEqual(30, calculated_score);
	}
}
