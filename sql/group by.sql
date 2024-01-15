select [state],count(*) as 'count' from authors group by state
select count(*) from authors
select stor_id,count(qty) from sales group by stor_id having sum(qty)> 50
select au_fname from authors		
select state,count(*) from authors group by state  