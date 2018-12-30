package org.bloodbank.project;



public class Acceptor {
	
	private String aceptName;
	private int aceptAge;
	private String occation;
	private int date;
	private String aceptBloodType;
	Acceptor acceptor;
	Blood blood;
	
	
	//get blood from blood class
	public Blood getBlood() {
		return blood;
	}
	//set blood to blood class
	public void setBlood(Blood blood) {
		this.blood = blood;
	}
	//get acceptor from acceptor class
	public Acceptor getAcceptor() {
		return acceptor;
	}
	//set acceptor to acceptor class
	public void setAcceptor(Acceptor acceptor) {
		this.acceptor = acceptor;
	}
	//get acceptor name from acceptor class
	public String getAceptName() {
		return aceptName;
	}
	//set acceptor name to acceptor class
	public void setAceptName(String aceptName) {
		this.aceptName = aceptName;
	}
	//get acceptor age from acceptor class
	public int getAceptAge() {
		return aceptAge;
	}
	//set acceptor age to acceptor class
	public void setAceptAge(int aceptAge) {
		this.aceptAge = aceptAge;
	}
	//get occasion from acceptor class
	public String getOccation() {
		return occation;
	}
	//set occasion to acceptor class
	public void setOccation(String occation) {
		this.occation = occation;
	}
	//get date from acceptor class
	public int getDate() {
		return date;
	}
	//set date to acceptor class
	public void setDate(int date) {
		this.date = date;
	}
	//get acceptor blood type from acceptor class
	public String getAceptBloodType() {
		return aceptBloodType;
	}
	//set acceptor blood type to acceptor
	public void setAceptBloodType(String aceptBloodType) {
		this.aceptBloodType = aceptBloodType;
	}
	
	
}
