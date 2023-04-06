package org.zerock.persistence;

import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.ResultSet;

import javax.sql.DataSource;

import org.apache.ibatis.session.SqlSession;
import org.apache.ibatis.session.SqlSessionFactory;
import org.junit.Test;
import org.junit.runner.RunWith;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.test.context.ContextConfiguration;
import org.springframework.test.context.junit4.SpringJUnit4ClassRunner;

import lombok.Setter;
import lombok.extern.log4j.Log4j;

@RunWith(SpringJUnit4ClassRunner.class)
@ContextConfiguration("file:src/main/webapp/WEB-INF/spring/root-context.xml")
@Log4j
public class DatsSoruceTests {
	
	@Setter(onMethod_ = @Autowired)
	private DataSource dataSource;
	
	@Setter(onMethod_ = @Autowired)
	private SqlSessionFactory sqlsession;
	
	@Test
	public void testConnection() {
		
		try (Connection con = dataSource.getConnection()){
			String sql = "select sysdate from dual";
			PreparedStatement ps = con.prepareStatement(sql);
			ResultSet rs = ps.executeQuery();
			rs.next();
			log.info(rs.getString(1));
			log.info(con);
		} catch (Exception e) {
			e.printStackTrace();
		}
		
	}
	
	@Test
	public void testMyBatis() {
		
		try (SqlSession session = sqlsession.openSession();
				Connection con = dataSource.getConnection()){
			log.info(session);
			String sql = "select sysdate from dual";
			PreparedStatement ps = con.prepareStatement(sql);
			ResultSet rs = ps.executeQuery();
			rs.next();
			log.info(rs.getString(1));
			log.info(con);
		} catch (Exception e) {
			e.printStackTrace();
		}
	}
	
	

}
