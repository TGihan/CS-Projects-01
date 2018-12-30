package org.bloodbank.project;

import junit.framework.Test;
import junit.framework.TestSuite;

import org.junit.runner.RunWith;
import org.junit.runners.Suite;
import org.junit.runners.Suite.SuiteClasses;

@RunWith(Suite.class)
@SuiteClasses({ BloodBankTest.class, BloodTest.class, DonorTest.class})
public class AllTests {
	public static Test suite() {
		TestSuite suite = new TestSuite(AllTests.class.getName());
		//$JUnit-BEGIN$
		suite.addTestSuite(DonorTest.class);
		suite.addTestSuite(BloodBankTest.class);
		//$JUnit-END$
		return suite;
	}
}
