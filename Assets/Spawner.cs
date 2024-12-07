using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] Tetrominoes;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (Tetrominoes == null || Tetrominoes.Length == 0)
        {
            Debug.LogError("Nenhum Tetromino foi configurado no Spawner. Verifique no Inspector.");
            return;
        }

        NewTetromino();
    }

    // Update is called once per frame
    public void NewTetromino()
    {
        if (Tetrominoes == null || Tetrominoes.Length == 0)
        {
            Debug.LogError("O array Tetrominoes está vazio! Adicione os prefabs no Inspector.");
            return;
        }

        Instantiate(Tetrominoes[Random.Range(0, Tetrominoes.Length)], transform.position, Quaternion.identity);
    }
}