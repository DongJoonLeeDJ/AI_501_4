package com.example.thyex.entity;

import lombok.*;
import org.hibernate.annotations.CreationTimestamp;

import javax.persistence.*;
import javax.validation.constraints.NotEmpty;
import java.time.LocalDateTime;

@Entity
@Getter
@Setter
@ToString
@AllArgsConstructor // 모든변수생성자
@NoArgsConstructor  // 기본생성자
public class Todo {

    @Id
    @Column(name = "id", nullable = false)
    @GeneratedValue(strategy = GenerationType.AUTO)
    private Long id;

    @NotEmpty(message = "필수 입력값입니다.")
    private String content;

    @Column(name="wdate", updatable = false)
    @CreationTimestamp
    private LocalDateTime wdate;

}
