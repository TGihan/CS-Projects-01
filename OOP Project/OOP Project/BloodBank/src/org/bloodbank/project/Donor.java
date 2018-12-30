package org.bloodbank.project;

public class Donor {

	//variables declaration
	private String donorName;
	private int donorId;
	private int donorAge;
	private String donorAddress;
	private int gettingDate;
	private int nextDate;
	private String telephone;
	
	Donor donor;
	Blood blood;
	
	
	//get blood from blood class
	public Blood getBlood() {
		return blood;
	}
	//set blood to blood class
	public void setBlood(Blood blood) {
		this.blood = blood;
	}
	//get donor from donor class
	public Donor getDonor() {
		return donor;
	}
	//set donor to donor class
	public void setDonor(Donor donor) {
		this.donor = donor;
	}
	//get donor name
	public String getDonorName() {
		return donorName;
	}
	//set donor name
	public void setDonorName(String donorName) {
		this.donorName = donorName;
	}
	//get donor id
	public int getDonorId() {
		return donorId;
	}
	//set donor id
	public void setDonorId(int donorId) {
		this.donorId = donorId;
	}
	//get donor age
	public int getDonorAge() {
		return donorAge;
	}
	//set donor age
	public void setDonorAge(int donorAge) {
		this.donorAge = donorAge;
	}
	//get donor address
	public String getDonorAddress() {
		return donorAddress;
	}
	//set donor address
	public void setDonorAddress(String donorAddress) {
		this.donorAddress = donorAddress;
	}
	//get blood getting date
	public int getGettingDate() {
		return gettingDate;
	}
	//set getting date
	public void setGettingDate(int gettingDate) {
		this.gettingDate = gettingDate;
	}
	//get next date
	public int getNextDate() {
		return nextDate;
	}
	//set next date
	public void setNextDate(int nextDate) {
		this.nextDate = nextDate;
	}
	//get telephone number
	public String getTelephone() {
		return telephone;
	}
	//set telephone number
	public void setTelephone(String telephone) {
		this.telephone = telephone;
	}
	
	
}
