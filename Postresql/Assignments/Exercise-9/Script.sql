CREATE OR REPLACE FUNCTION displayAllDesignation(a varchar(255))
RETURNS SETOF finaltestdb.public.user_table AS $$
BEGIN
  RETURN QUERY SELECT * FROM finaltestdb.public.user_table where designation = $1;
END
$$ LANGUAGE plpgsql;


SELECT * FROM displayAllDesignation('Developer');