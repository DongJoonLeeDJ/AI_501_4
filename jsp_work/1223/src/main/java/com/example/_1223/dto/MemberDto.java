package com.example._1223.dto;

public class MemberDto {

    private String email;
    private String pwd;
    private String gender;


    // toString constructor getter setter
    // 3개 만들기.....

    @Override
    public String toString() {
        return "MemberDto{" +
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

    public MemberDto(){}

    public MemberDto(String email, String pwd, String gender) {
        this.email = email;
        this.pwd = pwd;
        this.gender = gender;
    }
}
