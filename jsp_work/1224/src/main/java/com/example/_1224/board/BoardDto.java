package com.example._1224.board;

public class BoardDto {
    private int idx;
    private String name;
    private String title;
    private String content;
    private String wdate;

    public BoardDto(){}

    public BoardDto(int idx, String name, String title, String content, String wdate) {
        this.idx = idx;
        this.name = name;
        this.title = title;
        this.content = content;
        this.wdate = wdate;
    }

    @Override
    public String toString() {
        return "BoardDto{" +
                "idx=" + idx +
                ", name='" + name + '\'' +
                ", title='" + title + '\'' +
                ", content='" + content + '\'' +
                ", wdate='" + wdate + '\'' +
                '}';
    }

    public int getIdx() {
        return idx;
    }

    public void setIdx(int idx) {
        this.idx = idx;
    }

    public String getName() {
        return name;
    }

    public void setName(String name) {
        this.name = name;
    }

    public String getTitle() {
        return title;
    }

    public void setTitle(String title) {
        this.title = title;
    }

    public String getContent() {
        return content;
    }

    public void setContent(String content) {
        this.content = content;
    }

    public String getWdate() {
        return wdate;
    }

    public void setWdate(String wdate) {
        this.wdate = wdate;
    }
}
