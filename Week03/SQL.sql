DELIMITER //

CREATE PROCEDURE usp_GetEmployeesByDepartment(IN dept_id INT)
BEGIN
    SELECT 
        e.Emp_ID,
        e.Emp_Name,
        e.Email,
        d.Dep_Name
    FROM employees e
    JOIN department d ON e.Department_ID = d.Department_ID
    WHERE e.Department_ID = dept_id;
END //

DELIMITER ;
