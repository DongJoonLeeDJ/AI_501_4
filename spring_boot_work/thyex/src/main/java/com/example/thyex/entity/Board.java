package com.example.thyex.entity;

import com.example.thyex.dto.BoardFormDto;
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

    public static Board createBoard(BoardFormDto boardFormDto) {
        Board board = new Board();
        board.setContent(boardFormDto.getContent());
        board.setName(boardFormDto.getName());
        board.setTitle(boardFormDto.getTitle());
        board.setWdate(LocalDateTime.now());
        return board;
    }
}
