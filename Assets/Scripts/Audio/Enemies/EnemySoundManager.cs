using AI;
using UnityEngine;
using Utilities;

namespace Audio
{
    public class EnemySoundManager : Singleton<EnemySoundManager>
    {
        private WendigoSound _wendigoSound;

        private void Awake()
        {
            _wendigoSound = GetComponent<WendigoSound>();
        }

        public void PlayAttackSound(EnemyType enemyType)
        {
            switch (enemyType)
            {
                case EnemyType.Wendigo:
                    _wendigoSound.PlayAttackSound();
                    break;
            }
        }

        public void PlayDeathSound(EnemyType enemyType)
        {
            switch (enemyType)
            {
                case EnemyType.Wendigo:
                    _wendigoSound.PlayDeathSound();
                    break;
            }
        }
        
        public void PlayAlertSound(EnemyType enemyType)
        {
            switch (enemyType)
            {
                case EnemyType.Wendigo:
                    _wendigoSound.PlayAlertSound();
                    break;
            }
        }

        public void PlayDamageSound(EnemyType enemyType)
        {
            switch (enemyType)
            {
                case EnemyType.Wendigo:
                    _wendigoSound.PlayDamageSound();
                    break;
            }
        }

        public void PlayChaseSound(EnemyType enemyType)
        {
            switch (enemyType)
            {
                case EnemyType.Wendigo:
                    _wendigoSound.PlayChaseSound();
                    break;
            }
        }
    }
    
    public enum EnemyActionType{
        Attack,
        Alert,
        Chase,
        Damage,
        Death
    }
}