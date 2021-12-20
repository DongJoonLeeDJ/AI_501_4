package com.example._1220.dto;

public class Member {
    private String email;
    private String pwd;
    private String gender;

    public Member(){}

    public Member(String email, String pwd, String gender) {
        this.email = email;
        this.pwd = pwd;
        this.gender = gender;
    }

    @Override
    public String toString() {
        return "Member{" +
                "email='" + email + '\'' +
                ", pwd='" + pwd + '\'' +
                ", gender='" + gender + '\'' +
                '}';
    }

    public String getEmail() {
        return email;
    }

    public void setEmail(String email) {
        this.email = email;
    }

    public String getPwd() {
        return pwd;
    }

    public void setPwd(String pwd) {
        this.pwd = pwd;
    }

    public String getGender() {
        return gender;
    }

    public void setGender(String gender) {
        this.gender = gender;
    }
}
