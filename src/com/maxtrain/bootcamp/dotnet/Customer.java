package com.maxtrain.bootcamp.dotnet;

public class Customer {
	
	private static int nextId = 1;
	
	public void addSales(double amount) throws ArithmeticException {
		if(amount <= 0) {
			throw new ArithmeticException("Cannot add zero sales");
		}
		setSales(getSales() + amount);
	}
	
	private int _id;
	public int getId() {
		return _id;
	}
	public void setId(int id) {
		_id = id;
	}
	
	private String _name;
	public String getName() {
		return _name;
	}
	public void setName(String _name) {
		this._name = _name;
	}
	
	private boolean _isNationalAcct;
	public boolean getNationalAcct() {
		return _isNationalAcct;
	}
	public void setNationalAcct(boolean isNationalAcct) {
		this._isNationalAcct = isNationalAcct;
	}
	
	private double _sales;
	public double getSales() {
		return _sales;
	}
	public void setSales(double _sales) {
		this._sales = _sales;
	}
	
	public Customer(String name, boolean nationalAccount, double sales) {
		this.setId(nextId++);
		this.setName(name);
		this.setNationalAcct(nationalAccount);
		this.setSales(sales);
	}
	public Customer(String name, boolean nationalAccount) {
		this(name, nationalAccount, 0);
	}
	public Customer(String name) {
		this(name, false);
	}
	public Customer() {
		this(null);
	}

}
