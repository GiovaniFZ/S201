(defn Funcao[x]
  (*(* x x)x)
  )

(def x 7)
(println (Funcao x))
(println (map Funcao[1,2,3,4,5]))