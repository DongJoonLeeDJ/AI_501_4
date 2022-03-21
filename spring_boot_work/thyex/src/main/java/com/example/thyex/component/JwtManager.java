package com.example.thyex.component;

import com.example.thyex.entity.Member;
import io.jsonwebtoken.Claims;
import io.jsonwebtoken.Jwts;
import io.jsonwebtoken.SignatureAlgorithm;
import org.springframework.stereotype.Component;

import java.util.Date;
import java.util.HashMap;
import java.util.Map;
import java.util.Set;

@Component
public class JwtManager {
    private final String securityKey = "hello world"; // TODO 민감정보는 따로 분리하는 것이 좋다
    private final Long expiredTime = 1000 * 60L * 60L * 3L; // 유효시간 3시간

    /**
     * Member 정보를 담은 JWT 토큰을 생성한다.
     *
     * @param member Member 정보를 담은 객체
     * @return String JWT 토큰
     */
    public String generateJwtToken(Member member) {
        Date now = new Date();
        return Jwts.builder()
                .setSubject(member.getEmail()) // 보통 username
                .setHeader(createHeader())
                .setClaims(createClaims(member)) // 클레임, 토큰에 포함될 정보
                .setExpiration(new Date(now.getTime() + expiredTime)) // 만료일
                .signWith(SignatureAlgorithm.HS256, securityKey)
                .compact();
    }

    private Map<String, Object> createHeader() {
        Map<String, Object> header = new HashMap<>();
        header.put("typ", "JWT");
        header.put("alg", "HS256"); // 해시 256 사용하여 암호화
        header.put("regDate", System.currentTimeMillis());
        return header;
    }

    /**
     * 클레임(Claim)을 생성한다.
     *
     * @param member 토큰을 생성하기 위한 계정 정보를 담은 객체
     * @return Map<String, Object> 클레임(Claim)
     */
    private Map<String, Object> createClaims(Member member) {
        Map<String, Object> claims = new HashMap<>();
        claims.put("username", member.getEmail()); // username
        claims.put("roles", "ADMIN"); // 인가정보
        return claims;
    }

    //...중략...

    /**
     * Token 에서 Claim 을 가져온다.
     *
     * @param token JWT 토큰
     * @return Claims 클레임
     */
    private Claims getClaims(String token) {
        return Jwts.parser().setSigningKey(securityKey).parseClaimsJws(token).getBody();
    }

    /**
     * 토큰으로 부터 username 을 가져온다.
     *
     * @param token JWT 토큰
     * @return String Member 의 username
     */
    public String getUsernameFromToken(String token) {
        return (String) getClaims(token).get("username");
    }

    /**
     * 토큰으로 부터 인가 정보를 가져온다.
     *
     * @param token JWT 토큰
     * @return Set<MemberRole> role 정보를 가지고 있는 Set
     */
    public Set<String> getMemberRoleSetFromToken(String token) {
        return (Set<String>) getClaims(token).get("roles");
    }

}

