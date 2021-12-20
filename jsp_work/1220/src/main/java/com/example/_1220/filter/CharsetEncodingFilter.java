package com.example._1220.filter;

import javax.servlet.*;
import java.io.IOException;

public class CharsetEncodingFilter implements Filter {
    private String encoding;

    @Override
    public void doFilter(ServletRequest request, ServletResponse response, FilterChain chain)
            throws IOException, ServletException {
        request.setCharacterEncoding(encoding);
        chain.doFilter(request, response);
    }


    @Override
    public void init(FilterConfig fConfig) throws  ServletException {
        encoding = fConfig.getInitParameter("encoding");

        //인코딩을 따로 지정하지 않은 경우 기본값 세팅
        if(encoding == null) {
            encoding = "utf-8";
        }
    }


    @Override
    public void destroy() {
    }


}
