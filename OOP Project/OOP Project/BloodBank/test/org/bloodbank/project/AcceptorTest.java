package org.bloodbank.project;

import static org.junit.Assert.*;

public class AcceptorTest {

	//test acceptor class setName method
	public void testsetName() {
		Acceptor a1 = new Acceptor();
		a1.setAceptName("Gihan");
		assertEquals("Gihan", a1.getAceptName());
	}
	
	//test acceptor class setAge method
	public void testsetAge() {
		Acceptor a1 = new Acceptor();
		a1.setAceptAge(45);
		assertEquals(45, a1.getAceptAge());
	}
	//test acceptor class setOccasion method 
	public void testsetoccation() {
		Acceptor a1 = new Acceptor();
		a1.setOccation("Accident");
		assertEquals(001, a1.getOccation());
	}
	//test acceptor class setDate method
	public void testsetDate() {
		Acceptor a1 = new Acceptor();
		a1.setDate(20130921);
		assertEquals(20130921, a1.getDate());
	}
	//test acceptor class setBloodType method 
	public void testsetbloodType() {
		Acceptor a1 = new Acceptor();
		a1.setAceptBloodType("A+");
		assertEquals(20130321, a1.getAceptBloodType());
	}
	
	
}
