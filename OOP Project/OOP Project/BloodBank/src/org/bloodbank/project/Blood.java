package org.bloodbank.project;

public class Blood {
	
	//objects declaration
	private String bloodType;
	private int bloodPoint;
	Donor donor;
	Acceptor acceptor;
	
	//get acceptor from acceptor class
	public Acceptor getAcceptor() {
		return acceptor;
	}
	//set acceptor to acceptor class
	public void setAcceptor(Acceptor acceptor) {
		this.acceptor = acceptor;
	}
	//get donor from donor class
	public Donor getDonor() {
		return donor;
	}
	//set donor to donor class
	public void setDonor(Donor donor) {
		this.donor = donor;
	}
	//get blood type from blood class
	public String getBloodType() {
		return bloodType;
	}
	//set blood type to blood class
	public void setBloodType(String bloodType) {
		this.bloodType = bloodType;
	}
	//get blood point from blood class
	public int getBloodPoint() {
		return bloodPoint;
	}
	//set blood point to blood class
	public void setBloodPoint(int bloodPoint) {
		this.bloodPoint = bloodPoint;
	}
	
	
}
