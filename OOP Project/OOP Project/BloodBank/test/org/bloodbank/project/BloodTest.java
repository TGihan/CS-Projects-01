package org.bloodbank.project;

import junit.framework.TestCase;

public class BloodTest extends TestCase{

	//test blood class setBloodpoint method
	public void testbloodPoint() {
		Blood b=new Blood();
		b.setBloodPoint(10);
		assertEquals(10,b.getBloodPoint());
	}
	//test blood class setBloodtype method
	public void testbloodType() {
		Blood b=new Blood();
		b.setBloodType("A+");
		assertEquals("A+",b.getBloodType());
	}

}
