package com.example.thyex.entity;

import lombok.Getter;
import lombok.Setter;
import org.hibernate.annotations.CreationTimestamp;

import javax.persistence.*;
import java.time.LocalDateTime;

@Entity
@Getter
@Setter
public class BoardTail {
    @Id
    @Column(name = "boardtail_id", nullable = false)
    @GeneratedValue(strategy = GenerationType.AUTO)
    private Long id;

    private String name;
    private String content;

    @Column(name="wdate", updatable = false)
    @CreationTimestamp
    private LocalDateTime wdate;

    @ManyToOne
    @JoinColumn(name = "board_id")
    private Board board;

}
