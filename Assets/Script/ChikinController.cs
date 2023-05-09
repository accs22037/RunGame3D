using UnityEngine;
//キャラクターの移動スクリプト
[RequireComponent(typeof(CharacterController))] //キャラクターコントローラーをアタッチ
public class ChikinController : MonoBehaviour
{
    [SerializeField] private Animator animator; //アニメーション(インスペクタ)
    [SerializeField] private float moveSpeed = 1.0f; //移動速度(インスペクタ)
    private CharacterController _characterController; 
    private Transform _transform; 
    public Vector3 _moves;

    private void Start()
    {
        //キャッシュ
        _characterController = GetComponent<CharacterController>();
        _transform = transform;
        Application.targetFrameRate = 60;
    }

    private void Update()
    {
        //xの移動
        _moves.x = Input.GetAxis("Horizontal") * moveSpeed;
        //zの移動
        _moves.z = moveSpeed;

        //プレイヤーの向き
        _transform.LookAt(_transform.position + new Vector3(_moves.x, 0, _moves.z));
        _characterController.Move(_moves * Time.deltaTime);
        animator.SetFloat("MoveSpeed", new Vector3(_moves.x, 0, _moves.z).magnitude);

        _moves.y += Physics.gravity.y * 0.001f;
    }
}
