package com.example.thyex.entity;

import lombok.Getter;
import lombok.Setter;
import org.hibernate.annotations.CreationTimestamp;
import org.springframework.boot.context.properties.bind.DefaultValue;

import javax.persistence.*;
import java.time.LocalDateTime;
import java.util.ArrayList;
import java.util.List;

@Entity
@Getter
@Setter
public class Board {

    @Id
    @Column(name = "board_id", nullable = false)
    @GeneratedValue(strategy = GenerationType.AUTO)
    private Long id;

    private String name;
    private String title;
    private String content;
    
    @Column(name="wdate", updatable = false)
    @CreationTimestamp
    private LocalDateTime wdate;

    @OneToMany(mappedBy = "board",
            cascade = CascadeType.ALL
            , orphanRemoval = true,
            fetch = FetchType.LAZY)
    List<BoardTail> boardTailList
            = new ArrayList<>();

}
