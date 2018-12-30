package org.bloodbank.project;

import junit.framework.TestCase;

public class DonorTest extends TestCase {

	//test donor class setName method
	public void testsetName() {
		Donor d1 = new Donor();
		d1.setDonorName("Gihan");
		assertEquals("Gihan", d1.getDonorName());
	}
	//test donor class setAddress method
	public void testsetAddress() {
		Donor d1 = new Donor();
		d1.setDonorAddress("Hettipola");
		assertEquals("Hettipola", d1.getDonorAddress());
	}
	//test donor class setAge method
	public void testsetAge() {
		Donor d1 = new Donor();
		d1.setDonorAge(21);
		assertEquals(21, d1.getDonorAge());
	}
	//test donor class setId method
	public void testsetid() {
		Donor d1 = new Donor();
		d1.setDonorId(001);
		assertEquals(001, d1.getDonorId());
	}
	//test donor class gettingDate method
	public void testsetgettingDate() {
		Donor d1 = new Donor();
		d1.setGettingDate(20130921);
		assertEquals(20130921, d1.getGettingDate());
	}
	//test donor class setNextDate method
	public void testsetnextDate() {
		Donor d1 = new Donor();
		d1.setNextDate(20130321);
		assertEquals(20130321, d1.getNextDate());
	}
	//test donor class setTel method
	public void testsetTel() {
		Donor d1 = new Donor();
		d1.setTelephone("0770671291");
		assertEquals("0770671291", d1.getTelephone());
	}
	
}
