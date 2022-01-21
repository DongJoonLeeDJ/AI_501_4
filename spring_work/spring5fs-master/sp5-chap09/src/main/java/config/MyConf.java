package config;

import org.apache.tomcat.jdbc.pool.DataSource;
import org.mybatis.spring.SqlSessionFactoryBean;
import org.springframework.context.annotation.Bean;
import org.springframework.context.annotation.ComponentScan;
import org.springframework.context.annotation.Configuration;

import mybeans.AA;

@Configuration
@ComponentScan(basePackages = {"chap09.member","chap09.todo"})
public class MyConf {

	public MyConf() {
	}
	
	@Bean
	public AA aa() {
		return new AA();
	}
	
	@Bean(destroyMethod = "close")
	public DataSource dataSource() {
		DataSource ds = new DataSource();
		ds.setDriverClassName("com.mysql.jdbc.Driver");
		ds.setUrl("jdbc:mysql://localhost/aa?characterEncoding=utf8");
		ds.setUsername("root");
		ds.setPassword("1234");
		ds.setInitialSize(2);
		ds.setMaxActive(10);
		ds.setTestWhileIdle(true);
		ds.setMinEvictableIdleTimeMillis(60000 * 3);
		ds.setTimeBetweenEvictionRunsMillis(10 * 1000);
		return ds;
	}
	/*
	 * pom.xml 
	 * 1.
	 * mybatis.jar
	 * mybatis-spring.jar
	 * 2.
	 * SqlSessionFactoryBean 객체 주입
	 */
	
	@Bean
	public SqlSessionFactoryBean sqlsessionfactorybean() {
		SqlSessionFactoryBean ss = new SqlSessionFactoryBean();
		ss.setDataSource(dataSource());
		return ss;
	}
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
}
