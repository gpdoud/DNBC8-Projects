package com.maxtrain.bootcamp.dotnet.dnbc8;

import java.util.ArrayList;

public class TestBanking {

	void run() {
		
		ArrayList<IAccount> accounts = new ArrayList<IAccount>();
		
//		Account a1 = new Account();
//		debug(a1);
//		a1.deposit(1000);
//		a1.withdraw(250);
//		debug(a1);
//		accounts.add()
		
		Savings s1 = new Savings();
		s1.deposit(2000);
		s1.withdraw(100);
		s1.withdraw(2000);
		s1.deposit(-100);
		accounts.add(s1);
		
		Checking c1 = new Checking();
		c1.deposit(5000);
		c1.withdraw(3000);
		accounts.add(c1);
		
		Savings s2 = new Savings();
		s2.deposit(1500);
		s2.withdraw(300);
		accounts.add(s2);

		Checking c2 = new Checking();
		c2.deposit(5000);
		c2.withdraw(3000);
		accounts.add(c2);

		double total = 0;
		for(IAccount acct : accounts) {
			total += acct.getBalance();
			System.out.println(acct.toString());
		}
		String msg = String.format("----------------------------");
		System.out.println(msg);
		msg = String.format("%-19s: %-9.2f", "Total:", total);
		System.out.println(msg);
		
	}
	void debug(Object msg) {
		System.out.println(msg.toString());
	}
	public static void main(String[] args) {
		(new TestBanking()).run();
	}

}
