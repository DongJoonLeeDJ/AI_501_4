package com.example.thyex.study;

import lombok.*;

import javax.persistence.*;

@Entity
@Getter
@Setter
@ToString
@NoArgsConstructor
public class AA {

    public AA(int a, String bb) {
        this.a = a;
        this.bb = bb;
    }

    public AA(Long id, int a, String bb) {
        this.id = id;
        this.a = a;
        this.bb = bb;
    }

    @Id
    @Column(name = "id", nullable = false)
    @GeneratedValue(strategy = GenerationType.AUTO)
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
