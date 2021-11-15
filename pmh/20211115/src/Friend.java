import jdk.nashorn.internal.parser.Scanner;

import javax.swing.*;

public class Friend extends Object {
    protected String name;
    protected String tel;

    public Friend(String name, String tel) {
        this.name = name;
        this.tel = tel;
    }
    public void showInfo() {}
}

class UniFriend extends Friend {
    private String major;
    UniFriend(String name, String tel, String major) {
        super(name, tel);
        this.major = major;
    }
    @Override
    public void showInfo() {
        System.out.println("UniFriend");
        System.out.println("name = " + name);
        System.out.println("tel = " + tel);
        System.out.println("major = " + major);
    }
}

class CmpFriend extends Friend {
    private String department;

    CmpFriend(String name, String tel, String department) {
        super(name, tel);
        this.department = department;
    }

    public void showInfo() {
        System.out.println("CmpFriend");
        System.out.println("name = " + name);
        System.out.println("tel = " + tel);
        System.out.println("major = " + department);
    }
}
