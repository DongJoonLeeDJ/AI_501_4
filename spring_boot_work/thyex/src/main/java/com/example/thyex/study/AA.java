package com.example.thyex.study;

import lombok.Data;
import lombok.Getter;
import lombok.Setter;
import lombok.ToString;

import javax.persistence.Column;
import javax.persistence.Entity;
import javax.persistence.Id;

@Entity
@Getter
@Setter
@ToString
public class AA {

    @Id
    @Column(name = "id", nullable = false)
    private Long id;

    private int a;
    private String bb;

    public Long getId() {
        return id;
    }

    public void setId(Long id) {
        this.id = id;
    }
}
