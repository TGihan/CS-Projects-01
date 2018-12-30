package org.bloodbank.project;

import java.util.ArrayList;

import junit.framework.TestCase;

import org.bloodbank.project.Acceptor;
import org.bloodbank.project.Blood;
import org.bloodbank.project.BloodBank;
import org.bloodbank.project.Donor;

public class BloodBankTest extends TestCase{

	//objects declaration
	private Blood b1;
	private Blood b2;
	private Donor d1;
	private Donor d2;
	private Acceptor a1;
	private Acceptor a2;
	private BloodBank ml;
	
	//test blood bank class constructor
	public void testBloodBank() {
		BloodBank ml = new BloodBank("GihanBloodBank");
		
		assertEquals("GihanBloodBank", ml.name);
	}
	
	//object declaration and set data to methods
	public void setup() {
		//objects creating
		ml=new BloodBank("GihanBloodBank");
		
		b1=new Blood();
		b2=new Blood();
		
		d1=new Donor();
		d2=new Donor();
		a1=new Acceptor();
		a2=new Acceptor();
		
		//methods calling
		
		//blood methods
		b1.setBloodPoint(10);
		b1.setBloodType("A+");
		b2.setBloodPoint(5);
		b2.setBloodType("B-");
		//donor methods
		d1.setDonorAddress("Hettipola");
		d2.setDonorAddress("Kurunegala");
		d1.setDonorAge(21);
		d2.setDonorAge(23);
		d1.setDonorId(001);
		d2.setDonorId(002);
		d1.setDonorName("Gihan");
		d2.setDonorName("Coco");
		//acceptor methods
		a1.setAceptAge(40);
		a2.setAceptAge(34);
		a1.setAceptBloodType("A+");
		a2.setAceptBloodType("B-");
		a1.setAceptName("Panchala");
		a2.setAceptName("Janitha");
		a1.setDate(20131021);
		a2.setDate(20131123);
		a1.setOccation("Accident");
		a2.setOccation("Operation");
		
	}
	
	//test addBlood method from blood bank
	public void testaddBlood() {
		
		setup();
		addItems();
		
		//array size testing
		assertEquals(2, ml.getBlood().size());
		assertEquals(2, ml.getAcceptor().size());
		assertEquals(2, ml.getDonor().size());
		
		//array index testing
		assertEquals(0, ml.getBlood().indexOf(b1));
		assertEquals(1, ml.getBlood().indexOf(b2));
		
		//array index testing
		assertEquals(0, ml.getDonor().indexOf(d1));
		assertEquals(1, ml.getDonor().indexOf(d2));
		
		//array index testing
		assertEquals(0, ml.getAcceptor().indexOf(a1));
		assertEquals(1, ml.getAcceptor().indexOf(a2));
		
		ml.removeBlood(b1);
		assertEquals(1, ml.getBlood().size());
		
		ml.removeDonor(d1);
		assertEquals(1, ml.getDonor().size());
		
		ml.removeAcceptor(a1);
		assertEquals(1, ml.getAcceptor().size());
		
		//System.out.println(ml.blood.size());
		//System.out.println(ml.donor.size());
		//System.out.println(ml.acceptor.size());
		
	}
	//test giveBlood method from blood bank
	public void testgiveBlood() {
		
			// set up objects
			setup();
			addItems();
			assertTrue("Blood give correctly",ml.giveBlood(b1,d1));
			assertFalse("Blood already give",ml.giveBlood(b1,d1));
		
			assertTrue("Blood check in Passed", ml.bloodCheck(b1));
			
			assertFalse("Blood was already give", ml.bloodCheck(b1));
			assertFalse("Blood was never give", ml.bloodCheck(b2));
			
			// additional test From maximumBloods
			setup();
			//addItems();
		
			}
	/*
	public void testdonorCheck(){
		setup();
		addItems();
		assertTrue("Donor check in passed",ml.donorCheck(d1));
		
	}
	
	public void testacceptorCheck(){
		setup();
		addItems();
		assertTrue("Acceptor check in passed",ml.acceptorCheck(a1));
		
	}
	
	public void testbloodCheck(){
		setup();
		addItems();
		assertTrue("Blood check in passed",ml.bloodCheck(b1));
		
	}
	*/
	
	//test receiveBlood method from blood bank
	public void testreceiveBlood(){
		
		setup();
		addItems();
		assertTrue("Blood receive correctly",ml.receiveBlood(b1,a1));
		assertFalse("Blood already receive",ml.receiveBlood(b1,a1));
	}
	//test add items to array lists
	private void addItems() {
		
		ml.addBlood(b1);
		ml.addBlood(b2);
		ml.addDonor(d1);
		ml.addDonor(d2);
		ml.addAcceptor(a1);
		ml.addAcceptor(a2);
		
	}
	//test getBloodFromDoor method from blood bank
	public void testgetBloodFromDonor() {
		setup();
		addItems();
		assertEquals(0, ml.getBloodFromDonor(d1).size());
		ml.giveBlood(b1,d1);
		ArrayList<Blood> testBloods = ml.getBloodFromDonor(d1);
		assertEquals(1, testBloods.size());
		assertEquals(0, testBloods.indexOf(b1));
		//System.out.println(testBloods.isEmpty());
		ml.giveBlood(b2, d1);
		testBloods = ml.getBloodFromDonor(d1);
		//System.out.println(testBloods.size());
		assertEquals(2, testBloods.size());
		//System.out.println(testBloods.indexOf(b1));
		//System.out.println(testBloods.indexOf(b2));
		assertEquals(1, testBloods.indexOf(b2));
	}
	
	//test getAvailableBlood method from blood bank
	public void testgetAvailableBloods() {
		setup();
		addItems();
		ArrayList<Blood> testBloods = ml.getAvailableBloods();
		assertEquals(2, testBloods.size());
		assertEquals(1, testBloods.indexOf(b2));
		ml.giveBlood(b1, d1);
		testBloods = ml.getAvailableBloods();
		//System.out.println("Size"+testBloods.size());
		assertEquals(1, testBloods.size());
		//System.out.println("hello"+testBloods.indexOf(b1));
		assertEquals(0, testBloods.indexOf(b2));
		ml.giveBlood(b2, d1);
		testBloods = ml.getAvailableBloods();
		assertEquals(0, testBloods.size());
	}
	
	//test getUnavalableBloods method from blood bank
	public void testgetUnavailableBloods() {
		setup();
		addItems();
		assertEquals(0, ml.getUnavailableBloods().size());
		ml.giveBlood(b1, d1);
		ArrayList<Blood> testBloods = ml.getUnavailableBloods();
		assertEquals(1, testBloods.size());
		assertEquals(0, testBloods.indexOf(b1));
		ml.giveBlood(b2, d2);
		testBloods = ml.getUnavailableBloods();
		assertEquals(2, testBloods.size());
		assertEquals(1, testBloods.indexOf(b2));
	}
	//test testgiveBloodToAcceptor method from blood bank
	public void testgiveBloodtoAcceptor(){
		setup();
		addItems();
		assertEquals(0, ml.giveBloodtoAcceptor(a1).size());
		ml.receiveBlood(b1,a1);
		ArrayList<Blood> testBloods = ml.giveBloodtoAcceptor(a1);
		assertEquals(1, testBloods.size());
		ml.receiveBlood(b2, a1);
		testBloods = ml.giveBloodtoAcceptor(a1);
		assertEquals(2, testBloods.size());
		assertEquals(1, testBloods.indexOf(b2));
	
		
	}
	
	
}
