package com.java.org;

public class Grade {
	private int math;
	private int science;
	private int english;

	public Grade(int m, int s, int e) {
		math = m;
		science = s;
		english = e;
	}
	
	public double average() {
		return (double)(math+science+english)/3;
	}
}
