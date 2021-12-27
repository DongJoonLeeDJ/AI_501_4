package com.example._1224.member;

public class MemberDto {
    private int idx;
    private String email;
    private String pwd;
    private String gender;

    public MemberDto(){}

    public MemberDto(int idx, String email, String pwd, String gender) {
        this.idx = idx;
        this.email = email;
        this.pwd = pwd;
        this.gender = gender;
    }

    @Override
    public String toString() {
        return "MemberDto{" +
                "idx=" + idx +
                ", email='" + email + '\'' +
                ", pwd='" + pwd + '\'' +
                ", gender='" + gender + '\'' +
                '}';
    }

    public int getIdx() {
        return idx;
    }

    public void setIdx(int idx) {
        this.idx = idx;
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
