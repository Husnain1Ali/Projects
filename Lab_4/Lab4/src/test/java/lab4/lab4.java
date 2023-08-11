package lab4;

import org.openqa.selenium.By;
import org.openqa.selenium.WebDriver;
import org.openqa.selenium.WebElement;
import org.openqa.selenium.chrome.ChromeDriver;
import org.openqa.selenium.interactions.Actions;

public class lab4 {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		WebDriver driver = new ChromeDriver();
		driver.get("https://omayo.blogspot.in/");
		
		WebElement Try_it_button= driver.findElement(By.xpath("//button[text()=\"Try it\"]"));
		new Actions(driver).click(Try_it_button).perform();
		
		WebElement double_click_here= driver.findElement(By.xpath("//button[text()=\" Double click Here   \"]"));
		new Actions(driver).doubleClick(double_click_here).perform();
	}

}
