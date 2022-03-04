package com.example.thyex.entity;

import lombok.*;
import org.hibernate.annotations.CreationTimestamp;

import javax.persistence.Column;
import javax.persistence.Entity;
import javax.persistence.Id;
import java.time.LocalDateTime;

@Entity
@Getter
@Setter
@ToString
@AllArgsConstructor // 모든변수생성자
@NoArgsConstructor // 기본생성자
public class Todo {

    @Id
    @Column(name = "id", nullable = false)
    private Long id;

    private String content;

    @Column(name="wdate", updatable = false)
    @CreationTimestamp
    private LocalDateTime wdate;

}
