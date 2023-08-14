(defparameter listaum (list 1 2 3))
(defparameter listadois (list 4 5 6))

(defun operation(x)
  (if (> x 4)
    (* x x)
    (/ x 2)
    )
  )

(print (mapcar #'operation listaum))
(print (append (mapcar #'operation listaum) (mapcar #'operation listadois)))