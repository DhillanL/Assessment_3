using UnityEngine;
using UnityEditor;
using NUnit.Framework;

public class ScoreTests {

	[Test]
	public void Converttimetest()
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
}
