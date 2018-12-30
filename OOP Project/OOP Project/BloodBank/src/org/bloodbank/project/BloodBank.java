package org.bloodbank.project;

import java.util.ArrayList;

public class BloodBank {
//declare variables
	public String name;	
	public ArrayList<Donor> donor;
	public ArrayList<Blood> blood;
	public ArrayList<Acceptor> acceptor;
		
	//constructor
	public BloodBank(String nm){
		nm="GihanBloodBank";
		name=nm;
		blood = new ArrayList<Blood>();
		donor = new ArrayList<Donor>();
		acceptor = new ArrayList<Acceptor>();
	}

	//get name to blood bank class
	public String getName() {
		return name;
	}
	//set name to blood bank
	public void setName(String name) {
		this.name = name;
	}
	//get blood from blood array list
	public ArrayList<Blood> getBlood() {
		return blood;
	}
	//get donor from donor array list
	public ArrayList<Donor> getDonor() {
		return donor;
	}
	//get acceptor from acceptor array list
	public ArrayList<Acceptor> getAcceptor() {
		return acceptor;
	}
	//set blood to blood array list
	public void setBlood(ArrayList<Blood> blood) {
		this.blood = blood;
	}
	//set donor to donor array list
	public void setDonor(ArrayList<Donor> donor) {
		this.donor = donor;
	}
	//set acceptor to acceptor array list
	public void setAcceptor(ArrayList<Acceptor> acceptor) {
		this.acceptor = acceptor;
	}
	//add blood to blood class array list
	public void addBlood(Blood b) {
		this.blood.add(b);	
	}
	//remove blood from blood class array list
	public void removeBlood(Blood b) {
		this.blood.remove(b);
	}
	//add donor to donor class array list
	public void addDonor(Donor d) {
		this.donor.add(d);
	}
	//remove donor to donor class array list
	public void removeDonor(Donor d) {
		this.donor.remove(d);
	}
	//add acceptor to acceptor class array list
	public void addAcceptor(Acceptor a) {
		this.acceptor.add(a);
	}

	public void removeAcceptor(Acceptor a) {
		this.acceptor.remove(a);
	}
	//donor give blood to blood bank (assign a blood to donor) 
	public boolean giveBlood(Blood b, Donor d) {
		if ((b.getDonor() == null)){	
			b.setDonor(d);
			return true;
	}
		else {
			
			return false;
			
		}
	}
	//acceptor receive blood 
	public boolean receiveBlood(Blood b, Acceptor a) {
		if ((b.getAcceptor() == null)){	
			b.setAcceptor(a);
			return true;
	}
		else {
			return false;
		}
	}
	/*
	public boolean donorCheck(Donor d) {
		if (d.getBlood() != null) {
			d.setBlood(null);
				return true;
			}
			else {
				return false;
			}
	}
	
	public boolean acceptorCheck(Acceptor a) {
		if (a.getBlood() != null) {
			a.setBlood(null);
				return true;
			}
			else {
				return false;
			}
	}
	*/
	//check blood already have in blood bank
	public boolean bloodCheck(Blood b) {
		if (b.getDonor() != null) {
			b.setDonor(null);
				return true;
			}
			else {
				return false;
			}
	}
	
	//get blood from donor to blood class
	public ArrayList<Blood> getBloodFromDonor(Donor d) {
		ArrayList<Blood> result = new ArrayList<Blood>();
		for (Blood aBlood : this.getBlood()) {
			if ((aBlood.getDonor() != null) &&
					(aBlood.getDonor().getDonorName().equals(d.getDonorName())))
			
			{
				result.add(aBlood);
			}
		}
		return result;
	}
	//give blood to acceptor from blood class
	public ArrayList<Blood> giveBloodtoAcceptor(Acceptor a1) {
		ArrayList<Blood> result = new ArrayList<Blood>();
		for (Blood aBlood : this.getBlood()) {
			
			if ((aBlood.getAcceptor() != null) &&
					(aBlood.getAcceptor().getAceptName().equals(a1.getAceptName())))
		
			{
				
				result.add(aBlood);
				
			}
						
		}

		return result;
	}
	//get available blood in blood class
	public ArrayList<Blood> getAvailableBloods() {
		ArrayList<Blood> result = new ArrayList<Blood>();
		for (Blood aBlood : this.getBlood()) {
			
			if (aBlood.getDonor() == null) {
				result.add(aBlood);
			
			}
		}
		return result;
		
		
		
	}
	//get unavailable bloods in blood class
	public ArrayList<Blood> getUnavailableBloods() {
		ArrayList<Blood> result = new ArrayList<Blood>();
		for (Blood aBlood : this.getBlood()) {
			if (aBlood.getDonor() != null) {
				result.add(aBlood);
			}
		}
		return result;
	}
	//blood attributes to string
	public String toString() {
		return this.name +this.getBlood().size() + " Bloods " +this.getDonor().size() + " Donors";
		
	}
	
	public static void main(String[] args) {
		//object creation
		BloodBank BT=new BloodBank("GihanBloodBank");
		Blood b1 = new Blood();
		Blood b2 = new Blood();
		Donor d1=new Donor();
		Donor d2=new Donor();
		Acceptor a1=new Acceptor();
		Acceptor a2=new Acceptor();
		
		//set blood class data 
		b1.setBloodType("A+");
		b2.setBloodType("B-");
		b1.setBloodPoint(10);
		b2.setBloodPoint(5);
		
		//set donor class data
		d1.setDonorAddress("Hettipola");
		d2.setDonorAddress("Kurunegala");
		d1.setDonorAge(21);
		d2.setDonorAge(23);
		d1.setDonorId(001);
		d2.setDonorId(002);
		d1.setDonorName("Gihan");
		d2.setDonorName("Coco");
		d1.setGettingDate(20131012);
		d2.setGettingDate(2030903);
		d1.setNextDate(20140412);
		d2.setNextDate(20140203);
		d1.setTelephone("0770671291");
		d2.setTelephone("0789839184");
		/*
		d1.setBloodtype("A+");
		d2.setBloodtype("B-");
		d1.setBloodpoint(10);
		d2.setBloodpoint(5);
		*/
		
		//acceptor class data
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
		
		
		
		
		
		
		//new donors create
		Donor gihan = new Donor();
		Donor coco = new Donor();
		
		gihan.setDonorName("Gihan");
		coco.setDonorName("coco");
		System.out.println("################################################################################");
		System.out.println("################## B l o o d    B a n k    K u r u n e g a l a #################");
		System.out.println("################################################################################");
		
		//print current status
		BT.printStatus();
		//BT.donorCheck(d1);
		
		System.out.println("Enter a Donor >>>>>"+"\n");
		BT.addBlood(b1);
		BT.addDonor(d1);
		BT.giveBlood(b1, gihan);
		
		//print current status
		BT.printStatus();
		
		System.out.println("Enter a Donor >>>>>"+"\n");
		BT.addBlood(b2);
		BT.addDonor(d2);
		BT.giveBlood(b2, coco);
		BT.printStatus();
		
		System.out.println("Enter a Acceptor >>>>>"+"\n");
		BT.addAcceptor(a1);
		BT.receiveBlood(b1, a1);
		BT.giveBloodtoAcceptor(a1);
		BT.removeBlood(b1);
		BT.printStatus();
		
		System.out.println("Enter a Acceptor >>>>>"+"\n");
		BT.addAcceptor(a2);
		BT.giveBloodtoAcceptor(a2);
		BT.removeBlood(b2);
		BT.printStatus();
		

		
	}
	
	private void printStatus() {
		
		//System.out.println("\n"+"Status Report of BloodBank \n" +this.toString());
	
		System.out.println("Available Bloods : ");	
		//loop blood array list 
	for (Blood b : this.getBlood()) {
		String bt=b.getBloodType();
		int bp=b.getBloodPoint();
	
		//print blood information
		System.out.println(bt+ " of Blood "+bp+" Blood Point");
		
	}
	System.out.println("\nAvailable Donors : ");
	//loop donor array list 
	for (Donor p : this.getDonor()) {
		
		
		//int count=this.getBloodFromDonor(p).size();
		//System.out.println(count);
		
		String nam =p.getDonorName();
		String add=p.getDonorAddress();
		int age=p.getDonorAge();
		int id=p.getDonorId();
		int gd=p.getGettingDate();
		int nd=p.getNextDate();
		String tel=p.getTelephone();
		
		
		//String bt=p.getBloodtype();
		//int bp=p.getBloodpoint();
		
		//print donor information
		System.out.println( nam+" "+id+" "+age+" "+add+" "+gd+" "+nd+" "+tel);//+" "+bt+" "+bp);	
		
		
	}
	System.out.println("\nAvailable Acceptors : ");
	//loop acceptor arrya list 
	for(Acceptor a:this.getAcceptor()){
		
		String nm=a.getAceptName();
		int ag=a.getAceptAge();
		String occa=a.getOccation();
		int dat=a.getDate();
		String abt=a.getAceptBloodType();
		
		//print acceptor information
		System.out.println(nm+" "+ag+" "+occa+" "+dat+" "+abt);
	}
	
	//System.out.println(this.blood.size());
	//System.out.println(this.donor.size());
	//System.out.println(this.acceptor.size());
	
	System.out.println("\nBloods Available: "+ this.blood.size());
	System.out.println("Donors Available: "+ this.donor.size());
	System.out.println("Acceptors Available: "+ this.acceptor.size());
	
	
	System.out.println("\n"+"#################### E n d  o f  B l o o d  R e p o r t #######################"+"\n");
	}
}
