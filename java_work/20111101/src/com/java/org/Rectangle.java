package com.java.org;

public class Rectangle {
	private int x;
	private int y;
	private int width;
	private int height;
	private String name;
	// 생성자 메서드 클래스 변수를 초기화를 하고 있습니다.
	public Rectangle(int x, int y, int width, int height) {
		this.x = x;
		this.y = y;
		this.width = width;
		this.height = height;
	}
	public void setName(String name) {this.name = name;}
	// setter 방식으로 클래스 변수를 초기화 할 수 도 있다.
	public void setX(int x) { this.x =x; }

	// 넓이 구하는 메서드
	public int square() {
		return width * height;
	}

	public void show() {
		System.out.println("name = " + name);
		System.out.println("x = " + x);
		System.out.println("y = " + y);
		System.out.println("넓이는 " + square());
	}

	public boolean contains(Rectangle r) {
		if ((x + width) > (r.x + r.width)) {
			if ((y + height) > (r.y + r.height)) {
//				System.out.println("포함되어 있다");
				return true;
			}
		}
		return false;
	}
}
