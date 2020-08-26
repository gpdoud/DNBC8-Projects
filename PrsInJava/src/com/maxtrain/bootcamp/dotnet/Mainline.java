package com.maxtrain.bootcamp.dotnet;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.sql.Statement;

public class Mainline {

	public static void main(String[] args) throws Exception {
		
		Connection con = null;
		try {
			Class.forName("com.microsoft.sqlserver.jdbc.SQLServerDriver");
			String url = "jdbc:sqlserver://;servername=localhost\\sqlexpress;databaseName=PrsEfDb8;";
			con = DriverManager.getConnection(url,"prs", "prs");
			Statement st = con.createStatement();
			String sql = "Select * from Users;";
			ResultSet rs = st.executeQuery(sql);
			while(rs.next()) {
				int id = rs.getInt("Id");
				String username = rs.getString("Username");
				System.out.println(String.format("%d / %s", id, username));
			}
		} catch (Exception ex) {
			throw ex;
		} finally {
			con.close();
		}
		
	}

}
